﻿namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
    public partial class HentUdbudResponseMessage
    {
        
        private HentUdbudResponse1 hentUdbudResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud", Order=0)]
        public HentUdbudResponse1 HentUdbudResponse
        {
            get
            {
                return this.hentUdbudResponseField;
            }
            set
            {
                this.hentUdbudResponseField = value;
            }
        }
    }
}