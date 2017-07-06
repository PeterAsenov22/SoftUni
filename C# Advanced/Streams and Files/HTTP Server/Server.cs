namespace HTTP_Server
{
    using System;
    using System.Net;
    using System.Text;
    using System.Threading;

    public class Server
    {
        private static HttpListener httpListener = new HttpListener();

        public static void Main()
        {
            Console.WriteLine("Starting server...");
            httpListener.Prefixes.Add("http://localhost:5000/");
            httpListener.Start();
            Console.WriteLine("Server started.");
            Thread response = new Thread(ResponseThread);
            response.Start();
        }

        private static void ResponseThread()
        {
            while (true)
            {
                HttpListenerContext context = httpListener.GetContext(); 
                var requestedURL = context.Request.Url.AbsoluteUri;

                if (requestedURL == "http://localhost:5000/")
                {
                    byte[] responseArray =
                        Encoding.UTF8.GetBytes("<html><head><title>Home Page</title></head>" +
                     $@"<body><h1>Welcome to our test page.</h1><h4>You can check the server information <a href=""http://localhost:5000/info""> here </a></h4><h5>Congratulations for creating your first web app :)</h5></body></html>");
                    context.Response.OutputStream.Write(responseArray, 0,
                        responseArray.Length);
                    context.Response.KeepAlive = false;
                    context.Response.Close();
                    Console.WriteLine("Respone given to a request.");
                }
                else if (requestedURL == "http://localhost:5000/info")
                {
                    byte[] responseArray =
                        Encoding.UTF8.GetBytes("<html><head><title>Info Page</title></head>" +
                                               $"<body><h2>Current Time: {DateTime.Now}</h2><h2>Logical Processors: {Environment.ProcessorCount}</h2><h2></h2></body ></html>");
                    context.Response.OutputStream.Write(responseArray, 0,
                        responseArray.Length); 
                    context.Response.KeepAlive = false;
                    context.Response.Close();
                    Console.WriteLine("Respone given to a request.");
                }
                else
                {
                    byte[] responseArray =
                        Encoding.UTF8.GetBytes("<html><head><title>Error Page</title></head>" +
                                               @"<body><h2 style = ""color:red""> Error!Try going to the <a href = ""/""> home page </a></h2></body></html>");
                    context.Response.OutputStream.Write(responseArray, 0,
                        responseArray.Length);
                    context.Response.KeepAlive = false;
                    context.Response.Close();
                    Console.WriteLine("Respone given to a request.");
                }
            }
        }
    }
}
