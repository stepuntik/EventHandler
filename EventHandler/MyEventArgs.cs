namespace EventHandler
{
    public class MyEventArgs : EventArgs
    {
        public string Message { get; set; }

        public MyEventArgs(string message)
        {
            Message = message;
        }

        public delegate void MyEventHandler(object sender, MyEventArgs e);
    }
}
