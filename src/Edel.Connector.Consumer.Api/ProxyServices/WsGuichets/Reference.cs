//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace WsGuichets
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.fiea.org/tk/", ConfigurationName="WsGuichets.WsGuichet")]
    internal interface WsGuichet
    {
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8080/WsGuichet/tkCreateIdentificationRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsGuichets.tkCreateIdentificationResponse> tkCreateIdentificationAsync(WsGuichets.tkCreateIdentificationRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8080/WsGuichet/tkGetResultatTicket", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsGuichets.tkGetResultatTicketResponse> tkGetResultatTicketAsync(WsGuichets.tkGetResultatTicketRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeIdentification
    {
        
        private string userIdField;
        
        private string passwordField;
        
        private typeProfil profilField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public typeProfil Profil
        {
            get
            {
                return this.profilField;
            }
            set
            {
                this.profilField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeProfil
    {
        
        private string entrepriseField;
        
        private string zoneField;
        
        private string applicationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="NMTOKEN", Order=0)]
        public string Entreprise
        {
            get
            {
                return this.entrepriseField;
            }
            set
            {
                this.entrepriseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="NMTOKEN", Order=1)]
        public string Zone
        {
            get
            {
                return this.zoneField;
            }
            set
            {
                this.zoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=2)]
        public string Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeVersionPK
    {
        
        private string numeroVersionField;
        
        private string codeSiteVersionField;
        
        private string nomServiceField;
        
        private string codeSiteServiceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NumeroVersion
        {
            get
            {
                return this.numeroVersionField;
            }
            set
            {
                this.numeroVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=1)]
        public string CodeSiteVersion
        {
            get
            {
                return this.codeSiteVersionField;
            }
            set
            {
                this.codeSiteVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=2)]
        public string NomService
        {
            get
            {
                return this.nomServiceField;
            }
            set
            {
                this.nomServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=3)]
        public string CodeSiteService
        {
            get
            {
                return this.codeSiteServiceField;
            }
            set
            {
                this.codeSiteServiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeOperationPK
    {
        
        private typeVersionPK versionPKField;
        
        private string codeOperationField;
        
        private string codeSiteOperationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public typeVersionPK VersionPK
        {
            get
            {
                return this.versionPKField;
            }
            set
            {
                this.versionPKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=1)]
        public string CodeOperation
        {
            get
            {
                return this.codeOperationField;
            }
            set
            {
                this.codeOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=2)]
        public string CodeSiteOperation
        {
            get
            {
                return this.codeSiteOperationField;
            }
            set
            {
                this.codeSiteOperationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeAnomalie
    {
        
        private string codeField;
        
        private int severiteField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="NMTOKEN", Order=0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Severite
        {
            get
            {
                return this.severiteField;
            }
            set
            {
                this.severiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeReponse
    {
        
        private bool resultatField;
        
        private typeAnomalie anomalieField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Resultat
        {
            get
            {
                return this.resultatField;
            }
            set
            {
                this.resultatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public typeAnomalie Anomalie
        {
            get
            {
                return this.anomalieField;
            }
            set
            {
                this.anomalieField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkCreateIdentificationRequest", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkCreateIdentificationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsGuichets.typeIdentification Identification;
        
        public tkCreateIdentificationRequest()
        {
        }
        
        public tkCreateIdentificationRequest(WsGuichets.typeIdentification Identification)
        {
            this.Identification = Identification;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkCreateIdentificationResponse", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkCreateIdentificationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsGuichets.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public string Jeton;
        
        public tkCreateIdentificationResponse()
        {
        }
        
        public tkCreateIdentificationResponse(WsGuichets.typeReponse ReponseStandard, string Jeton)
        {
            this.ReponseStandard = ReponseStandard;
            this.Jeton = Jeton;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.fiea.org/tk/")]
    public partial class tkGetResultatTicketResponseReponseSpecifique
    {
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetResultatTicketRequest", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetResultatTicketRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public string Jeton;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public string Ticket;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=2)]
        public WsGuichets.typeOperationPK OperationPK;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=3)]
        public string ContexteCheckAcces;
        
        public tkGetResultatTicketRequest()
        {
        }
        
        public tkGetResultatTicketRequest(string Jeton, string Ticket, WsGuichets.typeOperationPK OperationPK, string ContexteCheckAcces)
        {
            this.Jeton = Jeton;
            this.Ticket = Ticket;
            this.OperationPK = OperationPK;
            this.ContexteCheckAcces = ContexteCheckAcces;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetResultatTicketResponse", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetResultatTicketResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsGuichets.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsGuichets.tkGetResultatTicketResponseReponseSpecifique ReponseSpecifique;
        
        public tkGetResultatTicketResponse()
        {
        }
        
        public tkGetResultatTicketResponse(WsGuichets.typeReponse ReponseStandard, WsGuichets.tkGetResultatTicketResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal interface WsGuichetChannel : WsGuichets.WsGuichet, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal partial class WsGuichetClient : System.ServiceModel.ClientBase<WsGuichets.WsGuichet>, WsGuichets.WsGuichet
    {
        
    /// <summary>
    /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
    /// </summary>
    /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
    /// <param name="clientCredentials">Informations d'identification du client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WsGuichetClient() : 
                base(WsGuichetClient.GetDefaultBinding(), WsGuichetClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WsGuichetBSOAP.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsGuichetClient(EndpointConfiguration endpointConfiguration) : 
                base(WsGuichetClient.GetBindingForEndpoint(endpointConfiguration), WsGuichetClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsGuichetClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WsGuichetClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsGuichetClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WsGuichetClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsGuichetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WsGuichets.tkCreateIdentificationResponse> tkCreateIdentificationAsync(WsGuichets.tkCreateIdentificationRequest request)
        {
            return base.Channel.tkCreateIdentificationAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsGuichets.tkGetResultatTicketResponse> tkGetResultatTicketAsync(WsGuichets.tkGetResultatTicketRequest request)
        {
            return base.Channel.tkGetResultatTicketAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WsGuichetBSOAP))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WsGuichetBSOAP))
            {
                return new System.ServiceModel.EndpointAddress("http://wspp-reswel-elv.equade.fr/wsguichet/WsGuichet");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WsGuichetClient.GetBindingForEndpoint(EndpointConfiguration.WsGuichetBSOAP);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WsGuichetClient.GetEndpointAddress(EndpointConfiguration.WsGuichetBSOAP);
        }
        
        public enum EndpointConfiguration
        {
            
            WsGuichetBSOAP,
        }
    }
}
