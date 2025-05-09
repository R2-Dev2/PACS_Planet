using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace FTP
{
    public class Client
    {
       
        private TcpListener messageListener;
        private TcpListener fileListener;
        private CancellationTokenSource cts;
        private Thread tMessage, tFiles;

        public string ipDestination;
        public int messagePortL;
        public int filePortL;
        public int messagePortS;
        public int filePortS;
        private string messageToSend;


        public void StartListening()
        {
            cts = new CancellationTokenSource();
            tMessage = new Thread(() => RunListenMessages(cts.Token));
            tFiles = new Thread(() => RunListedPdf(cts.Token));
            tMessage.Start();
            tFiles.Start();
        }

        public void StopListening()
        {
            cts?.Cancel();
            messageListener?.Stop();
            fileListener?.Stop();
        }

        private void RunListenMessages(CancellationToken token)
        {
            try
            {
                messageListener = new TcpListener(IPAddress.Any, messagePortL);
                messageListener.Start();
                while (!token.IsCancellationRequested)
                {
                    if (messageListener.Pending())
                    {
                        using (TcpClient client = messageListener.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, true))
                        {
                            int messageLength = reader.ReadInt32();
                            byte[] data = reader.ReadBytes(messageLength);
                            string receivedMessage = Encoding.UTF8.GetString(data);
                            string ip = IPAddress.Parse(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()).ToString();
                            OnMessageReceived(receivedMessage, ip);
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                OnMessageReceived($"Error: {ex.Message}", "");
                Console.WriteLine(ex);
            }
            finally
            {
                messageListener?.Stop();
            }
        }

        private void RunListedPdf(CancellationToken token)
        {
            try
            {
                fileListener = new TcpListener(IPAddress.Any, filePortL);
                fileListener.Start();
                while (!token.IsCancellationRequested)
                {
                    if (fileListener.Pending())
                    {
                        using (TcpClient client = fileListener.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        using (MemoryStream ms = new MemoryStream())
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                ms.Write(buffer, 0, bytesRead);
                            }
                            byte[] receivedData = ms.ToArray();
                            OnCredentialReceived(Convert.ToBase64String(receivedData));
                            Console.WriteLine(Convert.ToBase64String(receivedData));
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                OnCredentialReceived($"Error: {ex.Message}");
            }
            finally
            {
                fileListener?.Stop();
            }
        }

        public void SendMessage(string message)
        {
            this.messageToSend = message;

            Thread senderThread = new Thread(SendMessageTCP);
            senderThread.Start();
        }

        private void SendMessageTCP()
        {
            try
            {
                using (TcpClient client = new TcpClient(ipDestination, messagePortS))
                using (NetworkStream stream = client.GetStream())
                using (BinaryWriter writer = new BinaryWriter(stream, Encoding.UTF8, true))
                {
                    byte[] data = Encoding.UTF8.GetBytes(messageToSend);
                    writer.Write(data.Length);
                    writer.Write(data);
                }
            }
            catch (Exception ex)
            {
                OnMessageReceived($"Error enviant: {ex.Message}", "");
            }
        }

        public void SendFileTCP(string filePath)
        {
            try
            {
                using (TcpClient client = new TcpClient(ipDestination, filePortS))
                using (NetworkStream stream = client.GetStream())
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {

                        stream.Write(buffer, 0, bytesRead);

                    }
                }
            }
            catch (Exception ex)
            {
                OnCredentialReceived($"Error enviant: {ex.Message}");
            }
        }

        public class MessageEventArgs : System.EventArgs
        {
            public string msg;
            public string ip;
        }


        public event EventHandler MessageReceived;

        protected virtual void OnMessageReceived(string msg, string ip)
        {
            if (null != MessageReceived)
            {
                MessageEventArgs e = new MessageEventArgs();
                e.msg = msg;
                e.ip = ip;
                MessageReceived(this, e);
            }

        }

        public class CredMessgaeEventArgs : EventArgs
        {
            public string credential { get; set; }
        }

        public event EventHandler CredentialReceived;

        protected virtual void OnCredentialReceived(string credential)
        {
            if (null != CredentialReceived)
                {
                CredMessgaeEventArgs e = new CredMessgaeEventArgs();
                e.credential = credential;
                CredentialReceived(this, e);

            }
        }
    }
}

