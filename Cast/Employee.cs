namespace sandbox.Cast {
    internal class Employee {
        internal int Id { get; set; }
        internal int? Age { get; set; }
        internal string? Name { get; set; }
        internal String? Work;

        private string _secret;

        public string SecretWord {
            get { return _secret; }
            set { _secret = value; }
        }
    }

    internal class Manager : Employee {
        internal decimal? Height { get; set; }
    }

    internal class Director : Employee {
        internal int WorkExperience { get; set; }
    }
}
