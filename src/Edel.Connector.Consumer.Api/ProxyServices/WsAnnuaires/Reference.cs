//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace WsAnnuaires
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.fiea.org/tk/", ConfigurationName="WsAnnuaires.WsAnnuaire")]
    internal interface WsAnnuaire
    {
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8080/WsAnnuaire/tkGetServices", ReplyAction="http://www.fiea.org/tk/WsAnnuaire/tkGetServicesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsAnnuaires.tkGetServicesResponse> tkGetServicesAsync(WsAnnuaires.tkGetServicesRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8080/WsAnnuaire/tkGetOperationsServiceVersion", ReplyAction="http://www.fiea.org/tk/WsAnnuaire/tkGetOperationsServiceVersionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsAnnuaires.tkGetOperationsServiceVersionResponse> tkGetOperationsServiceVersionAsync(WsAnnuaires.tkGetOperationsServiceVersionRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8080/WsAnnuaire/tkGetVersionsService", ReplyAction="http://www.fiea.org/tk/WsAnnuaire/tkGetVersionsServiceResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsAnnuaires.tkGetVersionsServiceResponse> tkGetVersionsServiceAsync(WsAnnuaires.tkGetVersionsServiceRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8080/WsAnnuaire/tkGetUrl", ReplyAction="http://www.fiea.org/tk/WsAnnuaire/tkGetUrlResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<WsAnnuaires.tkGetUrlResponse> tkGetUrlAsync(WsAnnuaires.tkGetUrlRequest request);
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
    public partial class typeInfosServiceMetierRegional
    {
        
        private string urlGuichetField;
        
        private string wsdlGuichetField;
        
        private string urlMetierField;
        
        private string wsdlMetierField;
        
        private string urlRestGuichetField;
        
        private string urlRestMetierField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=0)]
        public string UrlGuichet
        {
            get
            {
                return this.urlGuichetField;
            }
            set
            {
                this.urlGuichetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=1)]
        public string WsdlGuichet
        {
            get
            {
                return this.wsdlGuichetField;
            }
            set
            {
                this.wsdlGuichetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=2)]
        public string UrlMetier
        {
            get
            {
                return this.urlMetierField;
            }
            set
            {
                this.urlMetierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=3)]
        public string WsdlMetier
        {
            get
            {
                return this.wsdlMetierField;
            }
            set
            {
                this.wsdlMetierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=4)]
        public string UrlRestGuichet
        {
            get
            {
                return this.urlRestGuichetField;
            }
            set
            {
                this.urlRestGuichetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=5)]
        public string UrlRestMetier
        {
            get
            {
                return this.urlRestMetierField;
            }
            set
            {
                this.urlRestMetierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeServicePK
    {
        
        private string nomServiceField;
        
        private string codeSiteServiceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=1)]
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
    public partial class typeVersion
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
    public partial class typeServiceVersion
    {
        
        private typeService serviceField;
        
        private typeVersion versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public typeService Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public typeVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeService
    {
        
        private string nomServiceField;
        
        private string codeSiteServiceField;
        
        private string codeDomaineField;
        
        private string codeEspeceField;
        
        private string libelleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=1)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=2)]
        public string CodeDomaine
        {
            get
            {
                return this.codeDomaineField;
            }
            set
            {
                this.codeDomaineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=3)]
        public string CodeEspece
        {
            get
            {
                return this.codeEspeceField;
            }
            set
            {
                this.codeEspeceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Libelle
        {
            get
            {
                return this.libelleField;
            }
            set
            {
                this.libelleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeOperation
    {
        
        private typeServiceVersion serviceVersionField;
        
        private string codeOperationField;
        
        private string codeSiteOperationField;
        
        private bool disponibleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public typeServiceVersion ServiceVersion
        {
            get
            {
                return this.serviceVersionField;
            }
            set
            {
                this.serviceVersionField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool Disponible
        {
            get
            {
                return this.disponibleField;
            }
            set
            {
                this.disponibleField = value;
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeEspeceAnimale
    {
        
        private string nomEspeceAnimaleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=0)]
        public string NomEspeceAnimale
        {
            get
            {
                return this.nomEspeceAnimaleField;
            }
            set
            {
                this.nomEspeceAnimaleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fiea.org/types/")]
    public partial class typeDomaine
    {
        
        private string nomDomaineField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", Order=0)]
        public string NomDomaine
        {
            get
            {
                return this.nomDomaineField;
            }
            set
            {
                this.nomDomaineField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.fiea.org/tk/")]
    public partial class tkGetServicesResponseReponseSpecifique
    {
        
        private typeService[] servicesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Service", Namespace="http://www.fiea.org/types/", IsNullable=false)]
        public typeService[] Services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetServicesRequest", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetServicesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeProfil ProfilDemandeur;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.typeDomaine Domaine;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=2)]
        public WsAnnuaires.typeEspeceAnimale Espece;
        
        public tkGetServicesRequest()
        {
        }
        
        public tkGetServicesRequest(WsAnnuaires.typeProfil ProfilDemandeur, WsAnnuaires.typeDomaine Domaine, WsAnnuaires.typeEspeceAnimale Espece)
        {
            this.ProfilDemandeur = ProfilDemandeur;
            this.Domaine = Domaine;
            this.Espece = Espece;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetServicesResponse", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetServicesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.tkGetServicesResponseReponseSpecifique ReponseSpecifique;
        
        public tkGetServicesResponse()
        {
        }
        
        public tkGetServicesResponse(WsAnnuaires.typeReponse ReponseStandard, WsAnnuaires.tkGetServicesResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.fiea.org/tk/")]
    public partial class tkGetOperationsServiceVersionResponseReponseSpecifique
    {
        
        private typeOperation[] operationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Operation", Namespace="http://www.fiea.org/types/", IsNullable=false)]
        public typeOperation[] Operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetOperationsServiceVersionRequest", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetOperationsServiceVersionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeProfil ProfilDemandeur;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.typeVersionPK VersionPK;
        
        public tkGetOperationsServiceVersionRequest()
        {
        }
        
        public tkGetOperationsServiceVersionRequest(WsAnnuaires.typeProfil ProfilDemandeur, WsAnnuaires.typeVersionPK VersionPK)
        {
            this.ProfilDemandeur = ProfilDemandeur;
            this.VersionPK = VersionPK;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetOperationsServiceVersionResponse", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetOperationsServiceVersionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.tkGetOperationsServiceVersionResponseReponseSpecifique ReponseSpecifique;
        
        public tkGetOperationsServiceVersionResponse()
        {
        }
        
        public tkGetOperationsServiceVersionResponse(WsAnnuaires.typeReponse ReponseStandard, WsAnnuaires.tkGetOperationsServiceVersionResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.fiea.org/tk/")]
    public partial class tkGetVersionsServiceResponseReponseSpecifique
    {
        
        private typeVersion[] versionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Version", Namespace="http://www.fiea.org/types/", IsNullable=false)]
        public typeVersion[] Versions
        {
            get
            {
                return this.versionsField;
            }
            set
            {
                this.versionsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetVersionsServiceRequest", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetVersionsServiceRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeProfil ProfilDemandeur;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.typeServicePK Service;
        
        public tkGetVersionsServiceRequest()
        {
        }
        
        public tkGetVersionsServiceRequest(WsAnnuaires.typeProfil ProfilDemandeur, WsAnnuaires.typeServicePK Service)
        {
            this.ProfilDemandeur = ProfilDemandeur;
            this.Service = Service;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetVersionsServiceResponse", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetVersionsServiceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.tkGetVersionsServiceResponseReponseSpecifique ReponseSpecifique;
        
        public tkGetVersionsServiceResponse()
        {
        }
        
        public tkGetVersionsServiceResponse(WsAnnuaires.typeReponse ReponseStandard, WsAnnuaires.tkGetVersionsServiceResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.fiea.org/tk/")]
    public partial class tkGetUrlResponseReponseSpecifique
    {
        
        private typeInfosServiceMetierRegional infosServiceMetierRegionalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public typeInfosServiceMetierRegional InfosServiceMetierRegional
        {
            get
            {
                return this.infosServiceMetierRegionalField;
            }
            set
            {
                this.infosServiceMetierRegionalField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetUrlRequest", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetUrlRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeProfil ProfilDemandeur;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.typeVersionPK VersionPK;
        
        public tkGetUrlRequest()
        {
        }
        
        public tkGetUrlRequest(WsAnnuaires.typeProfil ProfilDemandeur, WsAnnuaires.typeVersionPK VersionPK)
        {
            this.ProfilDemandeur = ProfilDemandeur;
            this.VersionPK = VersionPK;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="tkGetUrlResponse", WrapperNamespace="http://www.fiea.org/tk/", IsWrapped=true)]
    internal partial class tkGetUrlResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=0)]
        public WsAnnuaires.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fiea.org/tk/", Order=1)]
        public WsAnnuaires.tkGetUrlResponseReponseSpecifique ReponseSpecifique;
        
        public tkGetUrlResponse()
        {
        }
        
        public tkGetUrlResponse(WsAnnuaires.typeReponse ReponseStandard, WsAnnuaires.tkGetUrlResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal interface WsAnnuaireChannel : WsAnnuaires.WsAnnuaire, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    internal partial class WsAnnuaireClient : System.ServiceModel.ClientBase<WsAnnuaires.WsAnnuaire>, WsAnnuaires.WsAnnuaire
    {
        
    /// <summary>
    /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
    /// </summary>
    /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
    /// <param name="clientCredentials">Informations d'identification du client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WsAnnuaireClient() : 
                base(WsAnnuaireClient.GetDefaultBinding(), WsAnnuaireClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WsAnnuaireBSOAP.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsAnnuaireClient(EndpointConfiguration endpointConfiguration) : 
                base(WsAnnuaireClient.GetBindingForEndpoint(endpointConfiguration), WsAnnuaireClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsAnnuaireClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WsAnnuaireClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsAnnuaireClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WsAnnuaireClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsAnnuaireClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WsAnnuaires.tkGetServicesResponse> tkGetServicesAsync(WsAnnuaires.tkGetServicesRequest request)
        {
            return base.Channel.tkGetServicesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsAnnuaires.tkGetOperationsServiceVersionResponse> tkGetOperationsServiceVersionAsync(WsAnnuaires.tkGetOperationsServiceVersionRequest request)
        {
            return base.Channel.tkGetOperationsServiceVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsAnnuaires.tkGetVersionsServiceResponse> tkGetVersionsServiceAsync(WsAnnuaires.tkGetVersionsServiceRequest request)
        {
            return base.Channel.tkGetVersionsServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsAnnuaires.tkGetUrlResponse> tkGetUrlAsync(WsAnnuaires.tkGetUrlRequest request)
        {
            return base.Channel.tkGetUrlAsync(request);
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
            if ((endpointConfiguration == EndpointConfiguration.WsAnnuaireBSOAP))
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
            if ((endpointConfiguration == EndpointConfiguration.WsAnnuaireBSOAP))
            {
                return new System.ServiceModel.EndpointAddress("http://wstest1-directory.fiea.fr/wsannuaire/WsAnnuaire");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WsAnnuaireClient.GetBindingForEndpoint(EndpointConfiguration.WsAnnuaireBSOAP);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WsAnnuaireClient.GetEndpointAddress(EndpointConfiguration.WsAnnuaireBSOAP);
        }
        
        public enum EndpointConfiguration
        {
            
            WsAnnuaireBSOAP,
        }
    }
}
