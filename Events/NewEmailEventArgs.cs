namespace sandbox.Events {
    public class NewEmailEventArgs : EventArgs {
        private readonly string m_from;
        private readonly string m_to;
        private readonly string m_subject;

        public NewEmailEventArgs(string from, string to, string subject) {
            m_from = from;
            m_to = to;
            m_subject = subject;
        }

        public string From { get { return m_from; } }
        public string To { get { return m_to; } }
        public string Subject { get { return m_subject; } }
    }
}
