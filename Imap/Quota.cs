using System;
using System.Collections;

namespace AE.Net.Mail.Imap {
    public class Quota {
        private readonly string ressource;
        private readonly string usage;
        private readonly int used;
        private readonly int max;
        public Quota(string ressourceName, string usage, int used, int max) {
            this.ressource = ressourceName;
            this.usage = usage;
            this.used = used;
            this.max = max;
        }
        public virtual int Used => this.used;
        public virtual int Max => this.max;
    }
}