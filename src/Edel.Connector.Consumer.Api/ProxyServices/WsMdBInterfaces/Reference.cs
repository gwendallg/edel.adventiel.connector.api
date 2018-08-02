//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace WsMdBInterfaces
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MdB", ConfigurationName="WsMdBInterfaces.wsMdBInterface")]
    public interface wsMdBInterface
    {
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:OsBGetDonneesRACIn", ReplyAction="MdB/wsMdBInterface/OsBGetDonneesRACResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.OsBGetDonneesRACResponse> OsBGetDonneesRACAsync(WsMdBInterfaces.OsBGetDonneesRACRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:MdBGetDonneesMalesPublicsIn", ReplyAction="MdB/wsMdBInterface/MdBGetDonneesMalesPublicsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.MdBGetDonneesMalesPublicsResponse> MdBGetDonneesMalesPublicsAsync(WsMdBInterfaces.MdBGetDonneesMalesPublicsRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:MdBGetDonneesGenetiquesAnimalesIn", ReplyAction="MdB/wsMdBInterface/MdBGetDonneesGenetiquesAnimalesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.MdBGetDonneesGenetiquesAnimalesResponse> MdBGetDonneesGenetiquesAnimalesAsync(WsMdBInterfaces.MdBGetDonneesGenetiquesAnimalesRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:IaBGetDonneesIAIn", ReplyAction="MdB/wsMdBInterface/IaBGetDonneesIAResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.IaBGetDonneesIAResponse> IaBGetDonneesIAAsync(WsMdBInterfaces.IaBGetDonneesIARequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:TkBGetDonneesTEIn", ReplyAction="MdB/wsMdBInterface/TkBGetDonneesTEResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.TkBGetDonneesTEResponse> TkBGetDonneesTEAsync(WsMdBInterfaces.TkBGetDonneesTERequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:mCpBGetDonneesCPBIn", ReplyAction="MdB/wsMdBInterface/CpBGetDonneesCPBResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.CpBGetDonneesCPBResponse> CpBGetDonneesCPBAsync(WsMdBInterfaces.CpBGetDonneesCPBRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:ClBGetDonneesCLIn", ReplyAction="MdB/wsMdBInterface/ClBGetDonneesCLResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.ClBGetDonneesCLResponse> ClBGetDonneesCLAsync(WsMdBInterfaces.ClBGetDonneesCLRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:VaBGetDonneesCPVIn", ReplyAction="MdB/wsMdBInterface/VaBGetDonneesCPVResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.VaBGetDonneesCPVResponse> VaBGetDonneesCPVAsync(WsMdBInterfaces.VaBGetDonneesCPVRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs retournées.
        [System.ServiceModel.OperationContractAttribute(Action="MdB:MdBGetDonneesOrganismeTiersIn", ReplyAction="MdB/wsMdBInterface/MdBGetDonneesOrganismeTiersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Evenement))]
        System.Threading.Tasks.Task<WsMdBInterfaces.MdBGetDonneesOrganismeTiersResponse> MdBGetDonneesOrganismeTiersAsync(WsMdBInterfaces.MdBGetDonneesOrganismeTiersRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class typeIdentifiantExploitation
    {
        
        private TypeCodePays codePaysExploitationField;
        
        private string numeroExploitationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePaysExploitation
        {
            get
            {
                return this.codePaysExploitationField;
            }
            set
            {
                this.codePaysExploitationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroExploitation
        {
            get
            {
                return this.numeroExploitationField;
            }
            set
            {
                this.numeroExploitationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodePays:1")]
    public enum TypeCodePays
    {
        
        /// <remarks/>
        CD,
        
        /// <remarks/>
        TL,
        
        /// <remarks/>
        ZA,
        
        /// <remarks/>
        AL,
        
        /// <remarks/>
        DZ,
        
        /// <remarks/>
        DE,
        
        /// <remarks/>
        AD,
        
        /// <remarks/>
        AO,
        
        /// <remarks/>
        AI,
        
        /// <remarks/>
        AQ,
        
        /// <remarks/>
        AG,
        
        /// <remarks/>
        AN,
        
        /// <remarks/>
        SA,
        
        /// <remarks/>
        AR,
        
        /// <remarks/>
        AM,
        
        /// <remarks/>
        AW,
        
        /// <remarks/>
        AU,
        
        /// <remarks/>
        AT,
        
        /// <remarks/>
        AZ,
        
        /// <remarks/>
        BS,
        
        /// <remarks/>
        BH,
        
        /// <remarks/>
        BD,
        
        /// <remarks/>
        BB,
        
        /// <remarks/>
        BY,
        
        /// <remarks/>
        BE,
        
        /// <remarks/>
        BZ,
        
        /// <remarks/>
        BJ,
        
        /// <remarks/>
        BM,
        
        /// <remarks/>
        BT,
        
        /// <remarks/>
        BO,
        
        /// <remarks/>
        BV,
        
        /// <remarks/>
        BR,
        
        /// <remarks/>
        BN,
        
        /// <remarks/>
        BG,
        
        /// <remarks/>
        BF,
        
        /// <remarks/>
        BI,
        
        /// <remarks/>
        KY,
        
        /// <remarks/>
        KH,
        
        /// <remarks/>
        CM,
        
        /// <remarks/>
        CA,
        
        /// <remarks/>
        CV,
        
        /// <remarks/>
        CF,
        
        /// <remarks/>
        CL,
        
        /// <remarks/>
        CN,
        
        /// <remarks/>
        CX,
        
        /// <remarks/>
        CY,
        
        /// <remarks/>
        CC,
        
        /// <remarks/>
        CO,
        
        /// <remarks/>
        KM,
        
        /// <remarks/>
        CG,
        
        /// <remarks/>
        MS,
        
        /// <remarks/>
        ME,
        
        /// <remarks/>
        MZ,
        
        /// <remarks/>
        MM,
        
        /// <remarks/>
        NA,
        
        /// <remarks/>
        NR,
        
        /// <remarks/>
        TZ,
        
        /// <remarks/>
        TD,
        
        /// <remarks/>
        CZ,
        
        /// <remarks/>
        TF,
        
        /// <remarks/>
        TH,
        
        /// <remarks/>
        TG,
        
        /// <remarks/>
        TK,
        
        /// <remarks/>
        TO,
        
        /// <remarks/>
        TT,
        
        /// <remarks/>
        TN,
        
        /// <remarks/>
        TM,
        
        /// <remarks/>
        TC,
        
        /// <remarks/>
        TR,
        
        /// <remarks/>
        TV,
        
        /// <remarks/>
        UA,
        
        /// <remarks/>
        UY,
        
        /// <remarks/>
        VU,
        
        /// <remarks/>
        VA,
        
        /// <remarks/>
        VE,
        
        /// <remarks/>
        VN,
        
        /// <remarks/>
        PF,
        
        /// <remarks/>
        PR,
        
        /// <remarks/>
        QA,
        
        /// <remarks/>
        PT,
        
        /// <remarks/>
        RE,
        
        /// <remarks/>
        RO,
        
        /// <remarks/>
        UK,
        
        /// <remarks/>
        CH,
        
        /// <remarks/>
        YE,
        
        /// <remarks/>
        WF,
        
        /// <remarks/>
        ZW,
        
        /// <remarks/>
        SR,
        
        /// <remarks/>
        SJ,
        
        /// <remarks/>
        SE,
        
        /// <remarks/>
        SZ,
        
        /// <remarks/>
        ZM,
        
        /// <remarks/>
        SY,
        
        /// <remarks/>
        TJ,
        
        /// <remarks/>
        TW,
        
        /// <remarks/>
        XS,
        
        /// <remarks/>
        PS,
        
        /// <remarks/>
        CK,
        
        /// <remarks/>
        KR,
        
        /// <remarks/>
        KP,
        
        /// <remarks/>
        CR,
        
        /// <remarks/>
        CI,
        
        /// <remarks/>
        HR,
        
        /// <remarks/>
        CU,
        
        /// <remarks/>
        AF,
        
        /// <remarks/>
        DM,
        
        /// <remarks/>
        EG,
        
        /// <remarks/>
        SV,
        
        /// <remarks/>
        AE,
        
        /// <remarks/>
        EC,
        
        /// <remarks/>
        ER,
        
        /// <remarks/>
        ES,
        
        /// <remarks/>
        EE,
        
        /// <remarks/>
        US,
        
        /// <remarks/>
        ET,
        
        /// <remarks/>
        FK,
        
        /// <remarks/>
        FO,
        
        /// <remarks/>
        FJ,
        
        /// <remarks/>
        FI,
        
        /// <remarks/>
        FR,
        
        /// <remarks/>
        FX,
        
        /// <remarks/>
        GA,
        
        /// <remarks/>
        GM,
        
        /// <remarks/>
        GE,
        
        /// <remarks/>
        GS,
        
        /// <remarks/>
        GH,
        
        /// <remarks/>
        GI,
        
        /// <remarks/>
        EL,
        
        /// <remarks/>
        GD,
        
        /// <remarks/>
        GL,
        
        /// <remarks/>
        GP,
        
        /// <remarks/>
        BA,
        
        /// <remarks/>
        BW,
        
        /// <remarks/>
        GQ,
        
        /// <remarks/>
        GY,
        
        /// <remarks/>
        GF,
        
        /// <remarks/>
        HT,
        
        /// <remarks/>
        HM,
        
        /// <remarks/>
        HN,
        
        /// <remarks/>
        HK,
        
        /// <remarks/>
        HU,
        
        /// <remarks/>
        UM,
        
        /// <remarks/>
        VG,
        
        /// <remarks/>
        VI,
        
        /// <remarks/>
        IN,
        
        /// <remarks/>
        ID,
        
        /// <remarks/>
        IR,
        
        /// <remarks/>
        IQ,
        
        /// <remarks/>
        IE,
        
        /// <remarks/>
        IS,
        
        /// <remarks/>
        IL,
        
        /// <remarks/>
        IT,
        
        /// <remarks/>
        JM,
        
        /// <remarks/>
        JP,
        
        /// <remarks/>
        JO,
        
        /// <remarks/>
        KZ,
        
        /// <remarks/>
        KE,
        
        /// <remarks/>
        KG,
        
        /// <remarks/>
        DK,
        
        /// <remarks/>
        DJ,
        
        /// <remarks/>
        DO,
        
        /// <remarks/>
        LB,
        
        /// <remarks/>
        LR,
        
        /// <remarks/>
        LY,
        
        /// <remarks/>
        LI,
        
        /// <remarks/>
        LT,
        
        /// <remarks/>
        LU,
        
        /// <remarks/>
        MO,
        
        /// <remarks/>
        MG,
        
        /// <remarks/>
        MY,
        
        /// <remarks/>
        MW,
        
        /// <remarks/>
        MV,
        
        /// <remarks/>
        ML,
        
        /// <remarks/>
        MT,
        
        /// <remarks/>
        MP,
        
        /// <remarks/>
        MA,
        
        /// <remarks/>
        MH,
        
        /// <remarks/>
        MQ,
        
        /// <remarks/>
        MU,
        
        /// <remarks/>
        MR,
        
        /// <remarks/>
        YT,
        
        /// <remarks/>
        MX,
        
        /// <remarks/>
        FM,
        
        /// <remarks/>
        MC,
        
        /// <remarks/>
        MD,
        
        /// <remarks/>
        GU,
        
        /// <remarks/>
        MK,
        
        /// <remarks/>
        GT,
        
        /// <remarks/>
        GN,
        
        /// <remarks/>
        GW,
        
        /// <remarks/>
        NP,
        
        /// <remarks/>
        NI,
        
        /// <remarks/>
        NE,
        
        /// <remarks/>
        NG,
        
        /// <remarks/>
        NU,
        
        /// <remarks/>
        NF,
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        NC,
        
        /// <remarks/>
        NZ,
        
        /// <remarks/>
        IO,
        
        /// <remarks/>
        OM,
        
        /// <remarks/>
        UG,
        
        /// <remarks/>
        UZ,
        
        /// <remarks/>
        PK,
        
        /// <remarks/>
        PW,
        
        /// <remarks/>
        PA,
        
        /// <remarks/>
        PG,
        
        /// <remarks/>
        PY,
        
        /// <remarks/>
        NL,
        
        /// <remarks/>
        PE,
        
        /// <remarks/>
        PH,
        
        /// <remarks/>
        PN,
        
        /// <remarks/>
        PL,
        
        /// <remarks/>
        KI,
        
        /// <remarks/>
        KW,
        
        /// <remarks/>
        LA,
        
        /// <remarks/>
        LS,
        
        /// <remarks/>
        LV,
        
        /// <remarks/>
        RU,
        
        /// <remarks/>
        RW,
        
        /// <remarks/>
        EH,
        
        /// <remarks/>
        SH,
        
        /// <remarks/>
        KN,
        
        /// <remarks/>
        LC,
        
        /// <remarks/>
        SM,
        
        /// <remarks/>
        PM,
        
        /// <remarks/>
        VC,
        
        /// <remarks/>
        SB,
        
        /// <remarks/>
        WS,
        
        /// <remarks/>
        AS,
        
        /// <remarks/>
        ST,
        
        /// <remarks/>
        SN,
        
        /// <remarks/>
        SC,
        
        /// <remarks/>
        SL,
        
        /// <remarks/>
        SG,
        
        /// <remarks/>
        SK,
        
        /// <remarks/>
        SI,
        
        /// <remarks/>
        SO,
        
        /// <remarks/>
        SD,
        
        /// <remarks/>
        LK,
        
        /// <remarks/>
        MN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class LactationTiers
    {
        
        private int numeroLactationField;
        
        private System.DateTime dateLactationField;
        
        private bool dateLactationFieldSpecified;
        
        private TypeCodeEvenementDebutLactation evenementDebutLactationField;
        
        private bool evenementDebutLactationFieldSpecified;
        
        private TypeCodeStatutLactation etatLactationField;
        
        private bool etatLactationFieldSpecified;
        
        private string causeNonQualificationField;
        
        private string typeQualificationLactationField;
        
        private int dureeLactationField;
        
        private bool dureeLactationFieldSpecified;
        
        private int laitTotalLactationField;
        
        private bool laitTotalLactationFieldSpecified;
        
        private int mGTotalLactationField;
        
        private bool mGTotalLactationFieldSpecified;
        
        private int mPTotalLactationField;
        
        private bool mPTotalLactationFieldSpecified;
        
        private int tBTotalLactationField;
        
        private bool tBTotalLactationFieldSpecified;
        
        private int tPTotalLactationField;
        
        private bool tPTotalLactationFieldSpecified;
        
        private int laitReferenceField;
        
        private bool laitReferenceFieldSpecified;
        
        private int mGReferenceField;
        
        private bool mGReferenceFieldSpecified;
        
        private int mPReferenceField;
        
        private bool mPReferenceFieldSpecified;
        
        private int tBReferenceField;
        
        private bool tBReferenceFieldSpecified;
        
        private int tPReferenceField;
        
        private bool tPReferenceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int NumeroLactation
        {
            get
            {
                return this.numeroLactationField;
            }
            set
            {
                this.numeroLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=1)]
        public System.DateTime DateLactation
        {
            get
            {
                return this.dateLactationField;
            }
            set
            {
                this.dateLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateLactationSpecified
        {
            get
            {
                return this.dateLactationFieldSpecified;
            }
            set
            {
                this.dateLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TypeCodeEvenementDebutLactation EvenementDebutLactation
        {
            get
            {
                return this.evenementDebutLactationField;
            }
            set
            {
                this.evenementDebutLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EvenementDebutLactationSpecified
        {
            get
            {
                return this.evenementDebutLactationFieldSpecified;
            }
            set
            {
                this.evenementDebutLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public TypeCodeStatutLactation EtatLactation
        {
            get
            {
                return this.etatLactationField;
            }
            set
            {
                this.etatLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EtatLactationSpecified
        {
            get
            {
                return this.etatLactationFieldSpecified;
            }
            set
            {
                this.etatLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string CauseNonQualification
        {
            get
            {
                return this.causeNonQualificationField;
            }
            set
            {
                this.causeNonQualificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string TypeQualificationLactation
        {
            get
            {
                return this.typeQualificationLactationField;
            }
            set
            {
                this.typeQualificationLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int DureeLactation
        {
            get
            {
                return this.dureeLactationField;
            }
            set
            {
                this.dureeLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DureeLactationSpecified
        {
            get
            {
                return this.dureeLactationFieldSpecified;
            }
            set
            {
                this.dureeLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int LaitTotalLactation
        {
            get
            {
                return this.laitTotalLactationField;
            }
            set
            {
                this.laitTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaitTotalLactationSpecified
        {
            get
            {
                return this.laitTotalLactationFieldSpecified;
            }
            set
            {
                this.laitTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int MGTotalLactation
        {
            get
            {
                return this.mGTotalLactationField;
            }
            set
            {
                this.mGTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MGTotalLactationSpecified
        {
            get
            {
                return this.mGTotalLactationFieldSpecified;
            }
            set
            {
                this.mGTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int MPTotalLactation
        {
            get
            {
                return this.mPTotalLactationField;
            }
            set
            {
                this.mPTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MPTotalLactationSpecified
        {
            get
            {
                return this.mPTotalLactationFieldSpecified;
            }
            set
            {
                this.mPTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int TBTotalLactation
        {
            get
            {
                return this.tBTotalLactationField;
            }
            set
            {
                this.tBTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TBTotalLactationSpecified
        {
            get
            {
                return this.tBTotalLactationFieldSpecified;
            }
            set
            {
                this.tBTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int TPTotalLactation
        {
            get
            {
                return this.tPTotalLactationField;
            }
            set
            {
                this.tPTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TPTotalLactationSpecified
        {
            get
            {
                return this.tPTotalLactationFieldSpecified;
            }
            set
            {
                this.tPTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int LaitReference
        {
            get
            {
                return this.laitReferenceField;
            }
            set
            {
                this.laitReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaitReferenceSpecified
        {
            get
            {
                return this.laitReferenceFieldSpecified;
            }
            set
            {
                this.laitReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int MGReference
        {
            get
            {
                return this.mGReferenceField;
            }
            set
            {
                this.mGReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MGReferenceSpecified
        {
            get
            {
                return this.mGReferenceFieldSpecified;
            }
            set
            {
                this.mGReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public int MPReference
        {
            get
            {
                return this.mPReferenceField;
            }
            set
            {
                this.mPReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MPReferenceSpecified
        {
            get
            {
                return this.mPReferenceFieldSpecified;
            }
            set
            {
                this.mPReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int TBReference
        {
            get
            {
                return this.tBReferenceField;
            }
            set
            {
                this.tBReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TBReferenceSpecified
        {
            get
            {
                return this.tBReferenceFieldSpecified;
            }
            set
            {
                this.tBReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int TPReference
        {
            get
            {
                return this.tPReferenceField;
            }
            set
            {
                this.tPReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TPReferenceSpecified
        {
            get
            {
                return this.tPReferenceFieldSpecified;
            }
            set
            {
                this.tPReferenceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeEvenementDebutLactation:1")]
    public enum TypeCodeEvenementDebutLactation
    {
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        A,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public enum TypeCodeStatutLactation
    {
        
        /// <remarks/>
        Terminee,
        
        /// <remarks/>
        EnCours,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DonneeElaboreeAnimalTiers
    {
        
        private Organisation createurField;
        
        private CertificationParente certificationParenteField;
        
        private LactationTiers lactationTiersField;
        
        private IndexBovinLaitier indexBovinLaitierField;
        
        private PoidsAgeType poidsAgeTypeField;
        
        private IndexIBOVAL indexIBOVALField;
        
        private System.DateTime dateElaborationField;
        
        private bool dateElaborationFieldSpecified;
        
        private bool codeSuppressionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation Createur
        {
            get
            {
                return this.createurField;
            }
            set
            {
                this.createurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public CertificationParente CertificationParente
        {
            get
            {
                return this.certificationParenteField;
            }
            set
            {
                this.certificationParenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public LactationTiers LactationTiers
        {
            get
            {
                return this.lactationTiersField;
            }
            set
            {
                this.lactationTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public IndexBovinLaitier IndexBovinLaitier
        {
            get
            {
                return this.indexBovinLaitierField;
            }
            set
            {
                this.indexBovinLaitierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public PoidsAgeType PoidsAgeType
        {
            get
            {
                return this.poidsAgeTypeField;
            }
            set
            {
                this.poidsAgeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public IndexIBOVAL IndexIBOVAL
        {
            get
            {
                return this.indexIBOVALField;
            }
            set
            {
                this.indexIBOVALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=6)]
        public System.DateTime DateElaboration
        {
            get
            {
                return this.dateElaborationField;
            }
            set
            {
                this.dateElaborationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateElaborationSpecified
        {
            get
            {
                return this.dateElaborationFieldSpecified;
            }
            set
            {
                this.dateElaborationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Organisation
    {
        
        private Immatriculation immatriculationField;
        
        private string nomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Immatriculation Immatriculation
        {
            get
            {
                return this.immatriculationField;
            }
            set
            {
                this.immatriculationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Nom
        {
            get
            {
                return this.nomField;
            }
            set
            {
                this.nomField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Immatriculation
    {
        
        private string identifiantField;
        
        private string typeIdentifiantField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Identifiant
        {
            get
            {
                return this.identifiantField;
            }
            set
            {
                this.identifiantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TypeIdentifiant
        {
            get
            {
                return this.typeIdentifiantField;
            }
            set
            {
                this.typeIdentifiantField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class CertificationParente
    {
        
        private Bovin mereCertifieeField;
        
        private RefusCertification[] refusCertificationField;
        
        private Bovin pereCertifieField;
        
        private string codeRaceGenetiqueField;
        
        private string indicateurGenealogieCertifieeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Bovin MereCertifiee
        {
            get
            {
                return this.mereCertifieeField;
            }
            set
            {
                this.mereCertifieeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RefusCertification", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public RefusCertification[] RefusCertification
        {
            get
            {
                return this.refusCertificationField;
            }
            set
            {
                this.refusCertificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Bovin PereCertifie
        {
            get
            {
                return this.pereCertifieField;
            }
            set
            {
                this.pereCertifieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string CodeRaceGenetique
        {
            get
            {
                return this.codeRaceGenetiqueField;
            }
            set
            {
                this.codeRaceGenetiqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string IndicateurGenealogieCertifiee
        {
            get
            {
                return this.indicateurGenealogieCertifieeField;
            }
            set
            {
                this.indicateurGenealogieCertifieeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaureauReproducteur))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Bovin
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementAnimal[] evenementAnimalField;
        
        private DonneeElaboreeAnimal[] donneeElaboreeAnimalField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementAnimal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementAnimal[] EvenementAnimal
        {
            get
            {
                return this.evenementAnimalField;
            }
            set
            {
                this.evenementAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DonneeElaboreeAnimal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public DonneeElaboreeAnimal[] DonneeElaboreeAnimal
        {
            get
            {
                return this.donneeElaboreeAnimalField;
            }
            set
            {
                this.donneeElaboreeAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Identite
    {
        
        private string nomField;
        
        private System.DateTime dateNaissanceField;
        
        private bool dateNaissanceFieldSpecified;
        
        private string codeRaceBovinField;
        
        private string sexeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Nom
        {
            get
            {
                return this.nomField;
            }
            set
            {
                this.nomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=1)]
        public System.DateTime DateNaissance
        {
            get
            {
                return this.dateNaissanceField;
            }
            set
            {
                this.dateNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateNaissanceSpecified
        {
            get
            {
                return this.dateNaissanceFieldSpecified;
            }
            set
            {
                this.dateNaissanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CodeRaceBovin
        {
            get
            {
                return this.codeRaceBovinField;
            }
            set
            {
                this.codeRaceBovinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Sexe
        {
            get
            {
                return this.sexeField;
            }
            set
            {
                this.sexeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementAnimal
    {
        
        private EvenementsAnimauxIA evenementsAnimauxIAField;
        
        private EvenementsAnimauxTE evenementsAnimauxTEField;
        
        private EvenementsAnimauxCPB evenementsAnimauxCPBField;
        
        private EvenementsAnimauxCL evenementsAnimauxCLField;
        
        private EvenementsAnimauxCPV evenementsAnimauxCPVField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public EvenementsAnimauxIA EvenementsAnimauxIA
        {
            get
            {
                return this.evenementsAnimauxIAField;
            }
            set
            {
                this.evenementsAnimauxIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public EvenementsAnimauxTE EvenementsAnimauxTE
        {
            get
            {
                return this.evenementsAnimauxTEField;
            }
            set
            {
                this.evenementsAnimauxTEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public EvenementsAnimauxCPB EvenementsAnimauxCPB
        {
            get
            {
                return this.evenementsAnimauxCPBField;
            }
            set
            {
                this.evenementsAnimauxCPBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxCL EvenementsAnimauxCL
        {
            get
            {
                return this.evenementsAnimauxCLField;
            }
            set
            {
                this.evenementsAnimauxCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public EvenementsAnimauxCPV EvenementsAnimauxCPV
        {
            get
            {
                return this.evenementsAnimauxCPVField;
            }
            set
            {
                this.evenementsAnimauxCPVField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementsAnimauxIA : Evenement
    {
        
        private InseminationAnimale inseminationAnimaleField;
        
        private ConstatGestation constatGestationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InseminationAnimale InseminationAnimale
        {
            get
            {
                return this.inseminationAnimaleField;
            }
            set
            {
                this.inseminationAnimaleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ConstatGestation ConstatGestation
        {
            get
            {
                return this.constatGestationField;
            }
            set
            {
                this.constatGestationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class InseminationAnimale
    {
        
        private Inseminateur inseminateurField;
        
        private DoseSemence doseSemenceField;
        
        private string numeroBulletinIAField;
        
        private bool indicateurIAPourCollecteEmbryonField;
        
        private bool indicateurIAPourCollecteEmbryonFieldSpecified;
        
        private bool indicateurTraitementHormonalField;
        
        private bool indicateurTraitementHormonalFieldSpecified;
        
        private string pailletteFractionneeField;
        
        private bool indicateurIPEField;
        
        private bool indicateurIPEFieldSpecified;
        
        private bool indicateurIAReconnueField;
        
        private bool indicateurIAReconnueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Inseminateur Inseminateur
        {
            get
            {
                return this.inseminateurField;
            }
            set
            {
                this.inseminateurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DoseSemence DoseSemence
        {
            get
            {
                return this.doseSemenceField;
            }
            set
            {
                this.doseSemenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumeroBulletinIA
        {
            get
            {
                return this.numeroBulletinIAField;
            }
            set
            {
                this.numeroBulletinIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool IndicateurIAPourCollecteEmbryon
        {
            get
            {
                return this.indicateurIAPourCollecteEmbryonField;
            }
            set
            {
                this.indicateurIAPourCollecteEmbryonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIAPourCollecteEmbryonSpecified
        {
            get
            {
                return this.indicateurIAPourCollecteEmbryonFieldSpecified;
            }
            set
            {
                this.indicateurIAPourCollecteEmbryonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool IndicateurTraitementHormonal
        {
            get
            {
                return this.indicateurTraitementHormonalField;
            }
            set
            {
                this.indicateurTraitementHormonalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurTraitementHormonalSpecified
        {
            get
            {
                return this.indicateurTraitementHormonalFieldSpecified;
            }
            set
            {
                this.indicateurTraitementHormonalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string PailletteFractionnee
        {
            get
            {
                return this.pailletteFractionneeField;
            }
            set
            {
                this.pailletteFractionneeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool IndicateurIPE
        {
            get
            {
                return this.indicateurIPEField;
            }
            set
            {
                this.indicateurIPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIPESpecified
        {
            get
            {
                return this.indicateurIPEFieldSpecified;
            }
            set
            {
                this.indicateurIPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public bool IndicateurIAReconnue
        {
            get
            {
                return this.indicateurIAReconnueField;
            }
            set
            {
                this.indicateurIAReconnueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIAReconnueSpecified
        {
            get
            {
                return this.indicateurIAReconnueFieldSpecified;
            }
            set
            {
                this.indicateurIAReconnueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Inseminateur
    {
        
        private Organisation eMPField;
        
        private string codeInseminateurField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation EMP
        {
            get
            {
                return this.eMPField;
            }
            set
            {
                this.eMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CodeInseminateur
        {
            get
            {
                return this.codeInseminateurField;
            }
            set
            {
                this.codeInseminateurField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DoseSemence
    {
        
        private TaureauReproducteur taureauReproducteurField;
        
        private string referencePailletteField;
        
        private string statutReglementaireField;
        
        private string modeConservationField;
        
        private string semenceSexeeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TaureauReproducteur TaureauReproducteur
        {
            get
            {
                return this.taureauReproducteurField;
            }
            set
            {
                this.taureauReproducteurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ReferencePaillette
        {
            get
            {
                return this.referencePailletteField;
            }
            set
            {
                this.referencePailletteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string StatutReglementaire
        {
            get
            {
                return this.statutReglementaireField;
            }
            set
            {
                this.statutReglementaireField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string ModeConservation
        {
            get
            {
                return this.modeConservationField;
            }
            set
            {
                this.modeConservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string SemenceSexee
        {
            get
            {
                return this.semenceSexeeField;
            }
            set
            {
                this.semenceSexeeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class TaureauReproducteur : Bovin
    {
        
        private string numeroIETaureauField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string NumeroIETaureau
        {
            get
            {
                return this.numeroIETaureauField;
            }
            set
            {
                this.numeroIETaureauField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ConstatGestation
    {
        
        private string typeConstatGestationField;
        
        private string resultatConstatGestationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string TypeConstatGestation
        {
            get
            {
                return this.typeConstatGestationField;
            }
            set
            {
                this.typeConstatGestationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ResultatConstatGestation
        {
            get
            {
                return this.resultatConstatGestationField;
            }
            set
            {
                this.resultatConstatGestationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementsAnimauxTE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementsAnimauxRAC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementsAnimauxCPV))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassageControleLaitierTiers))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclarationInitialeMalePublic))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementAnimalTiers))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementsAnimauxCPB))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementsAnimauxCL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassageControleLaitier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvenementsAnimauxIA))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Evenement
    {
        
        private string identifiantField;
        
        private Organisation createurField;
        
        private System.DateTime dateDebutField;
        
        private System.DateTime dateFinField;
        
        private bool dateFinFieldSpecified;
        
        private bool codeSuppressionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Identifiant
        {
            get
            {
                return this.identifiantField;
            }
            set
            {
                this.identifiantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Organisation Createur
        {
            get
            {
                return this.createurField;
            }
            set
            {
                this.createurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=2)]
        public System.DateTime DateDebut
        {
            get
            {
                return this.dateDebutField;
            }
            set
            {
                this.dateDebutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=3)]
        public System.DateTime DateFin
        {
            get
            {
                return this.dateFinField;
            }
            set
            {
                this.dateFinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateFinSpecified
        {
            get
            {
                return this.dateFinFieldSpecified;
            }
            set
            {
                this.dateFinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementsAnimauxTE : Evenement
    {
        
        private CollecteEmbryons collecteEmbryonField;
        
        private MisePlaceEmbryon misePlaceEmbryonField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public CollecteEmbryons CollecteEmbryon
        {
            get
            {
                return this.collecteEmbryonField;
            }
            set
            {
                this.collecteEmbryonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public MisePlaceEmbryon MisePlaceEmbryon
        {
            get
            {
                return this.misePlaceEmbryonField;
            }
            set
            {
                this.misePlaceEmbryonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class CollecteEmbryons
    {
        
        private Organisation equipeCollecteField;
        
        private int nombreCollecteField;
        
        private string natureCollecteField;
        
        private string numeroBulletinCollecteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation EquipeCollecte
        {
            get
            {
                return this.equipeCollecteField;
            }
            set
            {
                this.equipeCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int NombreCollecte
        {
            get
            {
                return this.nombreCollecteField;
            }
            set
            {
                this.nombreCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NatureCollecte
        {
            get
            {
                return this.natureCollecteField;
            }
            set
            {
                this.natureCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string NumeroBulletinCollecte
        {
            get
            {
                return this.numeroBulletinCollecteField;
            }
            set
            {
                this.numeroBulletinCollecteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MisePlaceEmbryon
    {
        
        private Organisation equipeTransfertField;
        
        private EmbryonMisEnPlace embryonMisEnPlaceField;
        
        private string numeroBulletinTransfertField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation EquipeTransfert
        {
            get
            {
                return this.equipeTransfertField;
            }
            set
            {
                this.equipeTransfertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public EmbryonMisEnPlace EmbryonMisEnPlace
        {
            get
            {
                return this.embryonMisEnPlaceField;
            }
            set
            {
                this.embryonMisEnPlaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumeroBulletinTransfert
        {
            get
            {
                return this.numeroBulletinTransfertField;
            }
            set
            {
                this.numeroBulletinTransfertField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EmbryonMisEnPlace
    {
        
        private Bovin[] perePossibleField;
        
        private Bovin femelleDonneuseField;
        
        private string numeroEmbryonField;
        
        private string numeroBulletinCollecteField;
        
        private int ageEmbryonField;
        
        private string sexeEmbryonField;
        
        private string statutReglementaireField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PerePossible", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Bovin[] PerePossible
        {
            get
            {
                return this.perePossibleField;
            }
            set
            {
                this.perePossibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Bovin FemelleDonneuse
        {
            get
            {
                return this.femelleDonneuseField;
            }
            set
            {
                this.femelleDonneuseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumeroEmbryon
        {
            get
            {
                return this.numeroEmbryonField;
            }
            set
            {
                this.numeroEmbryonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string NumeroBulletinCollecte
        {
            get
            {
                return this.numeroBulletinCollecteField;
            }
            set
            {
                this.numeroBulletinCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int AgeEmbryon
        {
            get
            {
                return this.ageEmbryonField;
            }
            set
            {
                this.ageEmbryonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string SexeEmbryon
        {
            get
            {
                return this.sexeEmbryonField;
            }
            set
            {
                this.sexeEmbryonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string StatutReglementaire
        {
            get
            {
                return this.statutReglementaireField;
            }
            set
            {
                this.statutReglementaireField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementsAnimauxRAC : Evenement
    {
        
        private PointageAdulte pointageAdulteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public PointageAdulte PointageAdulte
        {
            get
            {
                return this.pointageAdulteField;
            }
            set
            {
                this.pointageAdulteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PointageAdulte
    {
        
        private string codeRaceVisiteField;
        
        private string versionTablePointageField;
        
        private string codeOperateurPointageField;
        
        private string pOSP01Field;
        
        private string pOSP02Field;
        
        private string pOSP03Field;
        
        private string pOSP04Field;
        
        private string pOSP05Field;
        
        private string pOSP06Field;
        
        private string pOSP07Field;
        
        private string pOSP08Field;
        
        private string pOSP09Field;
        
        private string pOSP10Field;
        
        private string pOSP11Field;
        
        private string pOSP12Field;
        
        private string pOSP13Field;
        
        private string pOSP14Field;
        
        private string pOSP15Field;
        
        private string pOSP16Field;
        
        private string pOSP17Field;
        
        private string pOSP18Field;
        
        private string pOSP19Field;
        
        private string pOSP20Field;
        
        private string pOSP21Field;
        
        private string pOSP22Field;
        
        private string pOSP23Field;
        
        private string pOSP24Field;
        
        private string pOSP25Field;
        
        private string pOSP26Field;
        
        private string pOSP27Field;
        
        private string pOSP28Field;
        
        private string pOSP29Field;
        
        private string pOSP30Field;
        
        private string pOSP31Field;
        
        private string pOSP32Field;
        
        private string pOSP33Field;
        
        private string pOSP34Field;
        
        private string pOSP35Field;
        
        private string pOSP36Field;
        
        private string pOSP37Field;
        
        private string pOSP38Field;
        
        private string pOSP39Field;
        
        private string pOSP40Field;
        
        private string pOSP41Field;
        
        private string pOSP42Field;
        
        private string pOSP43Field;
        
        private string pOSP44Field;
        
        private string pOSP45Field;
        
        private string pOSP46Field;
        
        private string pOSP47Field;
        
        private string pOSP48Field;
        
        private string pOSP49Field;
        
        private string pOSP50Field;
        
        private string pOSP51Field;
        
        private string pOSP52Field;
        
        private string pOSP53Field;
        
        private string pOSP54Field;
        
        private string pOSP55Field;
        
        private string pOSP56Field;
        
        private string pOSP57Field;
        
        private string pOSP58Field;
        
        private string pOSP59Field;
        
        private string pOSP60Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodeRaceVisite
        {
            get
            {
                return this.codeRaceVisiteField;
            }
            set
            {
                this.codeRaceVisiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string VersionTablePointage
        {
            get
            {
                return this.versionTablePointageField;
            }
            set
            {
                this.versionTablePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CodeOperateurPointage
        {
            get
            {
                return this.codeOperateurPointageField;
            }
            set
            {
                this.codeOperateurPointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string POSP01
        {
            get
            {
                return this.pOSP01Field;
            }
            set
            {
                this.pOSP01Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string POSP02
        {
            get
            {
                return this.pOSP02Field;
            }
            set
            {
                this.pOSP02Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string POSP03
        {
            get
            {
                return this.pOSP03Field;
            }
            set
            {
                this.pOSP03Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string POSP04
        {
            get
            {
                return this.pOSP04Field;
            }
            set
            {
                this.pOSP04Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string POSP05
        {
            get
            {
                return this.pOSP05Field;
            }
            set
            {
                this.pOSP05Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string POSP06
        {
            get
            {
                return this.pOSP06Field;
            }
            set
            {
                this.pOSP06Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string POSP07
        {
            get
            {
                return this.pOSP07Field;
            }
            set
            {
                this.pOSP07Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string POSP08
        {
            get
            {
                return this.pOSP08Field;
            }
            set
            {
                this.pOSP08Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string POSP09
        {
            get
            {
                return this.pOSP09Field;
            }
            set
            {
                this.pOSP09Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string POSP10
        {
            get
            {
                return this.pOSP10Field;
            }
            set
            {
                this.pOSP10Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string POSP11
        {
            get
            {
                return this.pOSP11Field;
            }
            set
            {
                this.pOSP11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string POSP12
        {
            get
            {
                return this.pOSP12Field;
            }
            set
            {
                this.pOSP12Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string POSP13
        {
            get
            {
                return this.pOSP13Field;
            }
            set
            {
                this.pOSP13Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string POSP14
        {
            get
            {
                return this.pOSP14Field;
            }
            set
            {
                this.pOSP14Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string POSP15
        {
            get
            {
                return this.pOSP15Field;
            }
            set
            {
                this.pOSP15Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string POSP16
        {
            get
            {
                return this.pOSP16Field;
            }
            set
            {
                this.pOSP16Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public string POSP17
        {
            get
            {
                return this.pOSP17Field;
            }
            set
            {
                this.pOSP17Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string POSP18
        {
            get
            {
                return this.pOSP18Field;
            }
            set
            {
                this.pOSP18Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string POSP19
        {
            get
            {
                return this.pOSP19Field;
            }
            set
            {
                this.pOSP19Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string POSP20
        {
            get
            {
                return this.pOSP20Field;
            }
            set
            {
                this.pOSP20Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public string POSP21
        {
            get
            {
                return this.pOSP21Field;
            }
            set
            {
                this.pOSP21Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public string POSP22
        {
            get
            {
                return this.pOSP22Field;
            }
            set
            {
                this.pOSP22Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public string POSP23
        {
            get
            {
                return this.pOSP23Field;
            }
            set
            {
                this.pOSP23Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public string POSP24
        {
            get
            {
                return this.pOSP24Field;
            }
            set
            {
                this.pOSP24Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public string POSP25
        {
            get
            {
                return this.pOSP25Field;
            }
            set
            {
                this.pOSP25Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public string POSP26
        {
            get
            {
                return this.pOSP26Field;
            }
            set
            {
                this.pOSP26Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public string POSP27
        {
            get
            {
                return this.pOSP27Field;
            }
            set
            {
                this.pOSP27Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public string POSP28
        {
            get
            {
                return this.pOSP28Field;
            }
            set
            {
                this.pOSP28Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public string POSP29
        {
            get
            {
                return this.pOSP29Field;
            }
            set
            {
                this.pOSP29Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public string POSP30
        {
            get
            {
                return this.pOSP30Field;
            }
            set
            {
                this.pOSP30Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=33)]
        public string POSP31
        {
            get
            {
                return this.pOSP31Field;
            }
            set
            {
                this.pOSP31Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=34)]
        public string POSP32
        {
            get
            {
                return this.pOSP32Field;
            }
            set
            {
                this.pOSP32Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=35)]
        public string POSP33
        {
            get
            {
                return this.pOSP33Field;
            }
            set
            {
                this.pOSP33Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=36)]
        public string POSP34
        {
            get
            {
                return this.pOSP34Field;
            }
            set
            {
                this.pOSP34Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=37)]
        public string POSP35
        {
            get
            {
                return this.pOSP35Field;
            }
            set
            {
                this.pOSP35Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=38)]
        public string POSP36
        {
            get
            {
                return this.pOSP36Field;
            }
            set
            {
                this.pOSP36Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=39)]
        public string POSP37
        {
            get
            {
                return this.pOSP37Field;
            }
            set
            {
                this.pOSP37Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=40)]
        public string POSP38
        {
            get
            {
                return this.pOSP38Field;
            }
            set
            {
                this.pOSP38Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=41)]
        public string POSP39
        {
            get
            {
                return this.pOSP39Field;
            }
            set
            {
                this.pOSP39Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=42)]
        public string POSP40
        {
            get
            {
                return this.pOSP40Field;
            }
            set
            {
                this.pOSP40Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=43)]
        public string POSP41
        {
            get
            {
                return this.pOSP41Field;
            }
            set
            {
                this.pOSP41Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=44)]
        public string POSP42
        {
            get
            {
                return this.pOSP42Field;
            }
            set
            {
                this.pOSP42Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=45)]
        public string POSP43
        {
            get
            {
                return this.pOSP43Field;
            }
            set
            {
                this.pOSP43Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=46)]
        public string POSP44
        {
            get
            {
                return this.pOSP44Field;
            }
            set
            {
                this.pOSP44Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=47)]
        public string POSP45
        {
            get
            {
                return this.pOSP45Field;
            }
            set
            {
                this.pOSP45Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=48)]
        public string POSP46
        {
            get
            {
                return this.pOSP46Field;
            }
            set
            {
                this.pOSP46Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=49)]
        public string POSP47
        {
            get
            {
                return this.pOSP47Field;
            }
            set
            {
                this.pOSP47Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=50)]
        public string POSP48
        {
            get
            {
                return this.pOSP48Field;
            }
            set
            {
                this.pOSP48Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=51)]
        public string POSP49
        {
            get
            {
                return this.pOSP49Field;
            }
            set
            {
                this.pOSP49Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=52)]
        public string POSP50
        {
            get
            {
                return this.pOSP50Field;
            }
            set
            {
                this.pOSP50Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=53)]
        public string POSP51
        {
            get
            {
                return this.pOSP51Field;
            }
            set
            {
                this.pOSP51Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=54)]
        public string POSP52
        {
            get
            {
                return this.pOSP52Field;
            }
            set
            {
                this.pOSP52Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=55)]
        public string POSP53
        {
            get
            {
                return this.pOSP53Field;
            }
            set
            {
                this.pOSP53Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=56)]
        public string POSP54
        {
            get
            {
                return this.pOSP54Field;
            }
            set
            {
                this.pOSP54Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=57)]
        public string POSP55
        {
            get
            {
                return this.pOSP55Field;
            }
            set
            {
                this.pOSP55Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=58)]
        public string POSP56
        {
            get
            {
                return this.pOSP56Field;
            }
            set
            {
                this.pOSP56Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=59)]
        public string POSP57
        {
            get
            {
                return this.pOSP57Field;
            }
            set
            {
                this.pOSP57Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=60)]
        public string POSP58
        {
            get
            {
                return this.pOSP58Field;
            }
            set
            {
                this.pOSP58Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=61)]
        public string POSP59
        {
            get
            {
                return this.pOSP59Field;
            }
            set
            {
                this.pOSP59Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=62)]
        public string POSP60
        {
            get
            {
                return this.pOSP60Field;
            }
            set
            {
                this.pOSP60Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementsAnimauxCPV : Evenement
    {
        
        private PeseeVif peseeVifField;
        
        private PointageSevrage pointageSevrageField;
        
        private Adoption adoptionField;
        
        private ConstatModeConduite constatModeConduiteField;
        
        private ConstatGroupeConduite constatGroupeConduiteField;
        
        private ConstatSituationParticuliereNaissanceSevrage constatSituationParticuliereNaissanceSevrageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public PeseeVif PeseeVif
        {
            get
            {
                return this.peseeVifField;
            }
            set
            {
                this.peseeVifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public PointageSevrage PointageSevrage
        {
            get
            {
                return this.pointageSevrageField;
            }
            set
            {
                this.pointageSevrageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Adoption Adoption
        {
            get
            {
                return this.adoptionField;
            }
            set
            {
                this.adoptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public ConstatModeConduite ConstatModeConduite
        {
            get
            {
                return this.constatModeConduiteField;
            }
            set
            {
                this.constatModeConduiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public ConstatGroupeConduite ConstatGroupeConduite
        {
            get
            {
                return this.constatGroupeConduiteField;
            }
            set
            {
                this.constatGroupeConduiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public ConstatSituationParticuliereNaissanceSevrage ConstatSituationParticuliereNaissanceSevrage
        {
            get
            {
                return this.constatSituationParticuliereNaissanceSevrageField;
            }
            set
            {
                this.constatSituationParticuliereNaissanceSevrageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PeseeVif
    {
        
        private decimal poidsVifPeseField;
        
        private bool poidsVifPeseFieldSpecified;
        
        private TypeCodeTypeOperateur codeTypeOperateurField;
        
        private TypeStadePhysiologique stadePhysiologiqueField;
        
        private bool stadePhysiologiqueFieldSpecified;
        
        private string typeConduitePSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal PoidsVifPese
        {
            get
            {
                return this.poidsVifPeseField;
            }
            set
            {
                this.poidsVifPeseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PoidsVifPeseSpecified
        {
            get
            {
                return this.poidsVifPeseFieldSpecified;
            }
            set
            {
                this.poidsVifPeseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TypeCodeTypeOperateur CodeTypeOperateur
        {
            get
            {
                return this.codeTypeOperateurField;
            }
            set
            {
                this.codeTypeOperateurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TypeStadePhysiologique StadePhysiologique
        {
            get
            {
                return this.stadePhysiologiqueField;
            }
            set
            {
                this.stadePhysiologiqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StadePhysiologiqueSpecified
        {
            get
            {
                return this.stadePhysiologiqueFieldSpecified;
            }
            set
            {
                this.stadePhysiologiqueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string TypeConduitePS
        {
            get
            {
                return this.typeConduitePSField;
            }
            set
            {
                this.typeConduitePSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeTypeOperateur:1")]
    public enum TypeCodeTypeOperateur
    {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        E,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:StadePhysiologique:1")]
    public enum TypeStadePhysiologique
    {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        V,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PointageSevrage
    {
        
        private TypeCodeSevragePointage codeSevragePointageField;
        
        private bool codeSevragePointageFieldSpecified;
        
        private int dessusEpauleCPVField;
        
        private int largeurDosCPVField;
        
        private int arrondiCulotteCPVField;
        
        private int largeurCulotteCPVField;
        
        private int epaisseurDessusCPVField;
        
        private int grosseurCanonsCPVField;
        
        private int longueurDessusCPVField;
        
        private int longueurBassinCPVField;
        
        private int largeurHanchesCPVField;
        
        private int developpementCPVField;
        
        private int largeurMufleCPVField;
        
        private int aplombsAvantCPVField;
        
        private int aplombsArriereCPVField;
        
        private int rectitudeDessusCPVField;
        
        private int noteEtatPointageCPVField;
        
        private int profondeurPoitrineCPVField;
        
        private bool profondeurPoitrineCPVFieldSpecified;
        
        private int largeurPoitrineCPVField;
        
        private bool largeurPoitrineCPVFieldSpecified;
        
        private int largeurTrochantersCPVField;
        
        private bool largeurTrochantersCPVFieldSpecified;
        
        private int longueurCulotteCPVField;
        
        private bool longueurCulotteCPVFieldSpecified;
        
        private int developpementMusculaireCPVField;
        
        private bool developpementMusculaireCPVFieldSpecified;
        
        private int developpementSquelettiqueCPVField;
        
        private bool developpementSquelettiqueCPVFieldSpecified;
        
        private int aptitudeFonctionnelleCPVField;
        
        private bool aptitudeFonctionnelleCPVFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeSevragePointage CodeSevragePointage
        {
            get
            {
                return this.codeSevragePointageField;
            }
            set
            {
                this.codeSevragePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSevragePointageSpecified
        {
            get
            {
                return this.codeSevragePointageFieldSpecified;
            }
            set
            {
                this.codeSevragePointageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int DessusEpauleCPV
        {
            get
            {
                return this.dessusEpauleCPVField;
            }
            set
            {
                this.dessusEpauleCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int LargeurDosCPV
        {
            get
            {
                return this.largeurDosCPVField;
            }
            set
            {
                this.largeurDosCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int ArrondiCulotteCPV
        {
            get
            {
                return this.arrondiCulotteCPVField;
            }
            set
            {
                this.arrondiCulotteCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int LargeurCulotteCPV
        {
            get
            {
                return this.largeurCulotteCPVField;
            }
            set
            {
                this.largeurCulotteCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int EpaisseurDessusCPV
        {
            get
            {
                return this.epaisseurDessusCPVField;
            }
            set
            {
                this.epaisseurDessusCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int GrosseurCanonsCPV
        {
            get
            {
                return this.grosseurCanonsCPVField;
            }
            set
            {
                this.grosseurCanonsCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int LongueurDessusCPV
        {
            get
            {
                return this.longueurDessusCPVField;
            }
            set
            {
                this.longueurDessusCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int LongueurBassinCPV
        {
            get
            {
                return this.longueurBassinCPVField;
            }
            set
            {
                this.longueurBassinCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int LargeurHanchesCPV
        {
            get
            {
                return this.largeurHanchesCPVField;
            }
            set
            {
                this.largeurHanchesCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int DeveloppementCPV
        {
            get
            {
                return this.developpementCPVField;
            }
            set
            {
                this.developpementCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int LargeurMufleCPV
        {
            get
            {
                return this.largeurMufleCPVField;
            }
            set
            {
                this.largeurMufleCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int AplombsAvantCPV
        {
            get
            {
                return this.aplombsAvantCPVField;
            }
            set
            {
                this.aplombsAvantCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int AplombsArriereCPV
        {
            get
            {
                return this.aplombsArriereCPVField;
            }
            set
            {
                this.aplombsArriereCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public int RectitudeDessusCPV
        {
            get
            {
                return this.rectitudeDessusCPVField;
            }
            set
            {
                this.rectitudeDessusCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int NoteEtatPointageCPV
        {
            get
            {
                return this.noteEtatPointageCPVField;
            }
            set
            {
                this.noteEtatPointageCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int ProfondeurPoitrineCPV
        {
            get
            {
                return this.profondeurPoitrineCPVField;
            }
            set
            {
                this.profondeurPoitrineCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfondeurPoitrineCPVSpecified
        {
            get
            {
                return this.profondeurPoitrineCPVFieldSpecified;
            }
            set
            {
                this.profondeurPoitrineCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int LargeurPoitrineCPV
        {
            get
            {
                return this.largeurPoitrineCPVField;
            }
            set
            {
                this.largeurPoitrineCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurPoitrineCPVSpecified
        {
            get
            {
                return this.largeurPoitrineCPVFieldSpecified;
            }
            set
            {
                this.largeurPoitrineCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public int LargeurTrochantersCPV
        {
            get
            {
                return this.largeurTrochantersCPVField;
            }
            set
            {
                this.largeurTrochantersCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurTrochantersCPVSpecified
        {
            get
            {
                return this.largeurTrochantersCPVFieldSpecified;
            }
            set
            {
                this.largeurTrochantersCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int LongueurCulotteCPV
        {
            get
            {
                return this.longueurCulotteCPVField;
            }
            set
            {
                this.longueurCulotteCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongueurCulotteCPVSpecified
        {
            get
            {
                return this.longueurCulotteCPVFieldSpecified;
            }
            set
            {
                this.longueurCulotteCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public int DeveloppementMusculaireCPV
        {
            get
            {
                return this.developpementMusculaireCPVField;
            }
            set
            {
                this.developpementMusculaireCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeveloppementMusculaireCPVSpecified
        {
            get
            {
                return this.developpementMusculaireCPVFieldSpecified;
            }
            set
            {
                this.developpementMusculaireCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int DeveloppementSquelettiqueCPV
        {
            get
            {
                return this.developpementSquelettiqueCPVField;
            }
            set
            {
                this.developpementSquelettiqueCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeveloppementSquelettiqueCPVSpecified
        {
            get
            {
                return this.developpementSquelettiqueCPVFieldSpecified;
            }
            set
            {
                this.developpementSquelettiqueCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public int AptitudeFonctionnelleCPV
        {
            get
            {
                return this.aptitudeFonctionnelleCPVField;
            }
            set
            {
                this.aptitudeFonctionnelleCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AptitudeFonctionnelleCPVSpecified
        {
            get
            {
                return this.aptitudeFonctionnelleCPVFieldSpecified;
            }
            set
            {
                this.aptitudeFonctionnelleCPVFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeSevragePointage:1")]
    public enum TypeCodeSevragePointage
    {
        
        /// <remarks/>
        JS,
        
        /// <remarks/>
        NR,
        
        /// <remarks/>
        NS,
        
        /// <remarks/>
        SV,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Adoption
    {
        
        private Bovin mereAdoptiveField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Bovin MereAdoptive
        {
            get
            {
                return this.mereAdoptiveField;
            }
            set
            {
                this.mereAdoptiveField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ConstatModeConduite
    {
        
        private TypeCodeModeConduite codeModeConduiteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeModeConduite CodeModeConduite
        {
            get
            {
                return this.codeModeConduiteField;
            }
            set
            {
                this.codeModeConduiteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeModeConduite:1")]
    public enum TypeCodeModeConduite
    {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        T,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ConstatGroupeConduite
    {
        
        private string campagneGroupeConduiteNSField;
        
        private string numeroGroupeConduiteNSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CampagneGroupeConduiteNS
        {
            get
            {
                return this.campagneGroupeConduiteNSField;
            }
            set
            {
                this.campagneGroupeConduiteNSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroGroupeConduiteNS
        {
            get
            {
                return this.numeroGroupeConduiteNSField;
            }
            set
            {
                this.numeroGroupeConduiteNSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ConstatSituationParticuliereNaissanceSevrage
    {
        
        private string codeSituationIndividuelleParticuliereField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodeSituationIndividuelleParticuliere
        {
            get
            {
                return this.codeSituationIndividuelleParticuliereField;
            }
            set
            {
                this.codeSituationIndividuelleParticuliereField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PassageControleLaitierTiers : Evenement
    {
        
        private ProtocoleControleLaitier protocoleControleLaitierField;
        
        private AgentTraite agentTraiteField;
        
        private int nombreTraitesPassageField;
        
        private bool nombreTraitesPassageFieldSpecified;
        
        private bool presenceRobotTraiteField;
        
        private bool presenceRobotTraiteFieldSpecified;
        
        private int nombreEchantillonsPrelevesField;
        
        private bool nombreEchantillonsPrelevesFieldSpecified;
        
        private HoraireTraite[] horaireTraiteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ProtocoleControleLaitier ProtocoleControleLaitier
        {
            get
            {
                return this.protocoleControleLaitierField;
            }
            set
            {
                this.protocoleControleLaitierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public AgentTraite AgentTraite
        {
            get
            {
                return this.agentTraiteField;
            }
            set
            {
                this.agentTraiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int NombreTraitesPassage
        {
            get
            {
                return this.nombreTraitesPassageField;
            }
            set
            {
                this.nombreTraitesPassageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreTraitesPassageSpecified
        {
            get
            {
                return this.nombreTraitesPassageFieldSpecified;
            }
            set
            {
                this.nombreTraitesPassageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool PresenceRobotTraite
        {
            get
            {
                return this.presenceRobotTraiteField;
            }
            set
            {
                this.presenceRobotTraiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PresenceRobotTraiteSpecified
        {
            get
            {
                return this.presenceRobotTraiteFieldSpecified;
            }
            set
            {
                this.presenceRobotTraiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int NombreEchantillonsPreleves
        {
            get
            {
                return this.nombreEchantillonsPrelevesField;
            }
            set
            {
                this.nombreEchantillonsPrelevesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreEchantillonsPrelevesSpecified
        {
            get
            {
                return this.nombreEchantillonsPrelevesFieldSpecified;
            }
            set
            {
                this.nombreEchantillonsPrelevesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HoraireTraite", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public HoraireTraite[] HoraireTraite
        {
            get
            {
                return this.horaireTraiteField;
            }
            set
            {
                this.horaireTraiteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ProtocoleControleLaitier
    {
        
        private TypeCodeProtocoleCL codeProtocoleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeProtocoleCL CodeProtocole
        {
            get
            {
                return this.codeProtocoleField;
            }
            set
            {
                this.codeProtocoleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeProtocoleCL:1")]
    public enum TypeCodeProtocoleCL
    {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        CR,
        
        /// <remarks/>
        AR,
        
        /// <remarks/>
        CT,
        
        /// <remarks/>
        AT,
        
        /// <remarks/>
        CZ,
        
        /// <remarks/>
        BR,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        AZ,
        
        /// <remarks/>
        BT,
        
        /// <remarks/>
        BZ,
        
        /// <remarks/>
        AP,
        
        /// <remarks/>
        AQ,
        
        /// <remarks/>
        CS,
        
        /// <remarks/>
        AU,
        
        /// <remarks/>
        BU,
        
        /// <remarks/>
        BS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class AgentTraite
    {
        
        private IdentifiantSectoriel identifiantSectorielField;
        
        private Immatriculation immatriculationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public IdentifiantSectoriel IdentifiantSectoriel
        {
            get
            {
                return this.identifiantSectorielField;
            }
            set
            {
                this.identifiantSectorielField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Immatriculation Immatriculation
        {
            get
            {
                return this.immatriculationField;
            }
            set
            {
                this.immatriculationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IdentifiantSectoriel
    {
        
        private string secteurControleurField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string SecteurControleur
        {
            get
            {
                return this.secteurControleurField;
            }
            set
            {
                this.secteurControleurField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class HoraireTraite
    {
        
        private System.DateTime heureDebutTraiteField;
        
        private bool heureDebutTraiteFieldSpecified;
        
        private System.DateTime heureFinTraiteField;
        
        private bool heureFinTraiteFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="time", Order=0)]
        public System.DateTime HeureDebutTraite
        {
            get
            {
                return this.heureDebutTraiteField;
            }
            set
            {
                this.heureDebutTraiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeureDebutTraiteSpecified
        {
            get
            {
                return this.heureDebutTraiteFieldSpecified;
            }
            set
            {
                this.heureDebutTraiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="time", Order=1)]
        public System.DateTime HeureFinTraite
        {
            get
            {
                return this.heureFinTraiteField;
            }
            set
            {
                this.heureFinTraiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeureFinTraiteSpecified
        {
            get
            {
                return this.heureFinTraiteFieldSpecified;
            }
            set
            {
                this.heureFinTraiteFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DeclarationInitialeMalePublic : Evenement
    {
        
        private TaureauReproducteur taureauReproducteurField;
        
        private Organisation entrepriseSelectionDeclaranteField;
        
        private string typeDeclarationInitialeField;
        
        private bool validiteDeclarationInitialeField;
        
        private bool validiteDeclarationInitialeFieldSpecified;
        
        private string typeProgrammeAgrementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TaureauReproducteur TaureauReproducteur
        {
            get
            {
                return this.taureauReproducteurField;
            }
            set
            {
                this.taureauReproducteurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Organisation EntrepriseSelectionDeclarante
        {
            get
            {
                return this.entrepriseSelectionDeclaranteField;
            }
            set
            {
                this.entrepriseSelectionDeclaranteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string TypeDeclarationInitiale
        {
            get
            {
                return this.typeDeclarationInitialeField;
            }
            set
            {
                this.typeDeclarationInitialeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool ValiditeDeclarationInitiale
        {
            get
            {
                return this.validiteDeclarationInitialeField;
            }
            set
            {
                this.validiteDeclarationInitialeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValiditeDeclarationInitialeSpecified
        {
            get
            {
                return this.validiteDeclarationInitialeFieldSpecified;
            }
            set
            {
                this.validiteDeclarationInitialeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string TypeProgrammeAgrement
        {
            get
            {
                return this.typeProgrammeAgrementField;
            }
            set
            {
                this.typeProgrammeAgrementField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementAnimalTiers : Evenement
    {
        
        private InseminationAnimaleTiers inseminationAnimaleTiersField;
        
        private ConstatGestationTiers constatGestationTiersField;
        
        private CollecteEmbryonsTiers collecteEmbryonTiersField;
        
        private MisePlaceEmbryonTiers misePlaceEmbryonTiersField;
        
        private MiseEnPresence miseEnPresenceField;
        
        private Avortement avortementField;
        
        private Velage velageField;
        
        private Mammite mammiteField;
        
        private DebutLactationTiers debutLactationTiersField;
        
        private ObservationLaitiereIndividuelle observationLaitiereField;
        
        private MouvementULConstate mouvementULConstateField;
        
        private PeseeVif peseeVifField;
        
        private PointageSevrageTiers pointageSevrageTiersField;
        
        private ConstatGroupeConduite constatGroupeConduiteField;
        
        private ConstatSituationParticuliereNaissanceSevrage constatSituationParticuliereNaissanceSevrageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InseminationAnimaleTiers InseminationAnimaleTiers
        {
            get
            {
                return this.inseminationAnimaleTiersField;
            }
            set
            {
                this.inseminationAnimaleTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ConstatGestationTiers ConstatGestationTiers
        {
            get
            {
                return this.constatGestationTiersField;
            }
            set
            {
                this.constatGestationTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public CollecteEmbryonsTiers CollecteEmbryonTiers
        {
            get
            {
                return this.collecteEmbryonTiersField;
            }
            set
            {
                this.collecteEmbryonTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public MisePlaceEmbryonTiers MisePlaceEmbryonTiers
        {
            get
            {
                return this.misePlaceEmbryonTiersField;
            }
            set
            {
                this.misePlaceEmbryonTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public MiseEnPresence MiseEnPresence
        {
            get
            {
                return this.miseEnPresenceField;
            }
            set
            {
                this.miseEnPresenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public Avortement Avortement
        {
            get
            {
                return this.avortementField;
            }
            set
            {
                this.avortementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public Velage Velage
        {
            get
            {
                return this.velageField;
            }
            set
            {
                this.velageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public Mammite Mammite
        {
            get
            {
                return this.mammiteField;
            }
            set
            {
                this.mammiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public DebutLactationTiers DebutLactationTiers
        {
            get
            {
                return this.debutLactationTiersField;
            }
            set
            {
                this.debutLactationTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public ObservationLaitiereIndividuelle ObservationLaitiere
        {
            get
            {
                return this.observationLaitiereField;
            }
            set
            {
                this.observationLaitiereField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public MouvementULConstate MouvementULConstate
        {
            get
            {
                return this.mouvementULConstateField;
            }
            set
            {
                this.mouvementULConstateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public PeseeVif PeseeVif
        {
            get
            {
                return this.peseeVifField;
            }
            set
            {
                this.peseeVifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public PointageSevrageTiers PointageSevrageTiers
        {
            get
            {
                return this.pointageSevrageTiersField;
            }
            set
            {
                this.pointageSevrageTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public ConstatGroupeConduite ConstatGroupeConduite
        {
            get
            {
                return this.constatGroupeConduiteField;
            }
            set
            {
                this.constatGroupeConduiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public ConstatSituationParticuliereNaissanceSevrage ConstatSituationParticuliereNaissanceSevrage
        {
            get
            {
                return this.constatSituationParticuliereNaissanceSevrageField;
            }
            set
            {
                this.constatSituationParticuliereNaissanceSevrageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class InseminationAnimaleTiers
    {
        
        private Inseminateur inseminateurField;
        
        private DoseSemence doseSemenceField;
        
        private string numeroBulletinIAField;
        
        private bool indicateurIAPourCollecteEmbryonField;
        
        private bool indicateurIAPourCollecteEmbryonFieldSpecified;
        
        private bool indicateurTraitementHormonalField;
        
        private bool indicateurTraitementHormonalFieldSpecified;
        
        private string pailletteFractionneeField;
        
        private bool indicateurIPEField;
        
        private bool indicateurIPEFieldSpecified;
        
        private bool indicateurIAReconnueField;
        
        private bool indicateurIAReconnueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Inseminateur Inseminateur
        {
            get
            {
                return this.inseminateurField;
            }
            set
            {
                this.inseminateurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DoseSemence DoseSemence
        {
            get
            {
                return this.doseSemenceField;
            }
            set
            {
                this.doseSemenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumeroBulletinIA
        {
            get
            {
                return this.numeroBulletinIAField;
            }
            set
            {
                this.numeroBulletinIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool IndicateurIAPourCollecteEmbryon
        {
            get
            {
                return this.indicateurIAPourCollecteEmbryonField;
            }
            set
            {
                this.indicateurIAPourCollecteEmbryonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIAPourCollecteEmbryonSpecified
        {
            get
            {
                return this.indicateurIAPourCollecteEmbryonFieldSpecified;
            }
            set
            {
                this.indicateurIAPourCollecteEmbryonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool IndicateurTraitementHormonal
        {
            get
            {
                return this.indicateurTraitementHormonalField;
            }
            set
            {
                this.indicateurTraitementHormonalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurTraitementHormonalSpecified
        {
            get
            {
                return this.indicateurTraitementHormonalFieldSpecified;
            }
            set
            {
                this.indicateurTraitementHormonalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string PailletteFractionnee
        {
            get
            {
                return this.pailletteFractionneeField;
            }
            set
            {
                this.pailletteFractionneeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool IndicateurIPE
        {
            get
            {
                return this.indicateurIPEField;
            }
            set
            {
                this.indicateurIPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIPESpecified
        {
            get
            {
                return this.indicateurIPEFieldSpecified;
            }
            set
            {
                this.indicateurIPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public bool IndicateurIAReconnue
        {
            get
            {
                return this.indicateurIAReconnueField;
            }
            set
            {
                this.indicateurIAReconnueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIAReconnueSpecified
        {
            get
            {
                return this.indicateurIAReconnueFieldSpecified;
            }
            set
            {
                this.indicateurIAReconnueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ConstatGestationTiers
    {
        
        private string typeConstatGestationField;
        
        private string resultatConstatGestationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string TypeConstatGestation
        {
            get
            {
                return this.typeConstatGestationField;
            }
            set
            {
                this.typeConstatGestationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ResultatConstatGestation
        {
            get
            {
                return this.resultatConstatGestationField;
            }
            set
            {
                this.resultatConstatGestationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class CollecteEmbryonsTiers
    {
        
        private Organisation equipeCollecteField;
        
        private int nombreCollecteField;
        
        private bool nombreCollecteFieldSpecified;
        
        private string natureCollecteField;
        
        private string numeroBulletinCollecteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation EquipeCollecte
        {
            get
            {
                return this.equipeCollecteField;
            }
            set
            {
                this.equipeCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int NombreCollecte
        {
            get
            {
                return this.nombreCollecteField;
            }
            set
            {
                this.nombreCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreCollecteSpecified
        {
            get
            {
                return this.nombreCollecteFieldSpecified;
            }
            set
            {
                this.nombreCollecteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NatureCollecte
        {
            get
            {
                return this.natureCollecteField;
            }
            set
            {
                this.natureCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string NumeroBulletinCollecte
        {
            get
            {
                return this.numeroBulletinCollecteField;
            }
            set
            {
                this.numeroBulletinCollecteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MisePlaceEmbryonTiers
    {
        
        private Organisation equipeTransfertField;
        
        private EmbryonMisEnPlace embryonMisEnPlaceField;
        
        private string numeroBulletinTransfertField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation EquipeTransfert
        {
            get
            {
                return this.equipeTransfertField;
            }
            set
            {
                this.equipeTransfertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public EmbryonMisEnPlace EmbryonMisEnPlace
        {
            get
            {
                return this.embryonMisEnPlaceField;
            }
            set
            {
                this.embryonMisEnPlaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumeroBulletinTransfert
        {
            get
            {
                return this.numeroBulletinTransfertField;
            }
            set
            {
                this.numeroBulletinTransfertField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MiseEnPresence
    {
        
        private TaureauReproducteur taureauReproducteurField;
        
        private string statutReglementaireField;
        
        private string typeMonteNaturelleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TaureauReproducteur TaureauReproducteur
        {
            get
            {
                return this.taureauReproducteurField;
            }
            set
            {
                this.taureauReproducteurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string StatutReglementaire
        {
            get
            {
                return this.statutReglementaireField;
            }
            set
            {
                this.statutReglementaireField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string TypeMonteNaturelle
        {
            get
            {
                return this.typeMonteNaturelleField;
            }
            set
            {
                this.typeMonteNaturelleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Avortement
    {
        
        private int rangFinGestationField;
        
        private bool rangFinGestationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int RangFinGestation
        {
            get
            {
                return this.rangFinGestationField;
            }
            set
            {
                this.rangFinGestationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RangFinGestationSpecified
        {
            get
            {
                return this.rangFinGestationFieldSpecified;
            }
            set
            {
                this.rangFinGestationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Velage
    {
        
        private string conditionVelageField;
        
        private int rangVelageField;
        
        private bool rangVelageFieldSpecified;
        
        private string indicateurVelageMultipleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ConditionVelage
        {
            get
            {
                return this.conditionVelageField;
            }
            set
            {
                this.conditionVelageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int RangVelage
        {
            get
            {
                return this.rangVelageField;
            }
            set
            {
                this.rangVelageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RangVelageSpecified
        {
            get
            {
                return this.rangVelageFieldSpecified;
            }
            set
            {
                this.rangVelageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string IndicateurVelageMultiple
        {
            get
            {
                return this.indicateurVelageMultipleField;
            }
            set
            {
                this.indicateurVelageMultipleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Mammite
    {
        
        private TypeCodeOrigineCollecteMammite codeOrigineCollecteField;
        
        private bool codeOrigineCollecteFieldSpecified;
        
        private string severiteMammiteField;
        
        private System.DateTime dateCollecteMammiteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeOrigineCollecteMammite CodeOrigineCollecte
        {
            get
            {
                return this.codeOrigineCollecteField;
            }
            set
            {
                this.codeOrigineCollecteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeOrigineCollecteSpecified
        {
            get
            {
                return this.codeOrigineCollecteFieldSpecified;
            }
            set
            {
                this.codeOrigineCollecteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string SeveriteMammite
        {
            get
            {
                return this.severiteMammiteField;
            }
            set
            {
                this.severiteMammiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=2)]
        public System.DateTime DateCollecteMammite
        {
            get
            {
                return this.dateCollecteMammiteField;
            }
            set
            {
                this.dateCollecteMammiteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeOrigineCollecteMammite:1")]
    public enum TypeCodeOrigineCollecteMammite
    {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DebutLactationTiers
    {
        
        private int numeroLactationField;
        
        private TypeCodeEvenementDebutLactation evenementDebutLactationField;
        
        private bool evenementDebutLactationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int NumeroLactation
        {
            get
            {
                return this.numeroLactationField;
            }
            set
            {
                this.numeroLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TypeCodeEvenementDebutLactation EvenementDebutLactation
        {
            get
            {
                return this.evenementDebutLactationField;
            }
            set
            {
                this.evenementDebutLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EvenementDebutLactationSpecified
        {
            get
            {
                return this.evenementDebutLactationFieldSpecified;
            }
            set
            {
                this.evenementDebutLactationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ObservationLaitiereIndividuelle
    {
        
        private int numeroLactationField;
        
        private int numeroControleField;
        
        private bool numeroControleFieldSpecified;
        
        private TypeCodeEtatFemelle codeEtatFemelleField;
        
        private int laitTotalObservationField;
        
        private bool laitTotalObservationFieldSpecified;
        
        private string causeAbsenceTauxField;
        
        private int tPObservationField;
        
        private bool tPObservationFieldSpecified;
        
        private int tBObservationField;
        
        private bool tBObservationFieldSpecified;
        
        private int cellulesObservationField;
        
        private bool cellulesObservationFieldSpecified;
        
        private int ureeObservationField;
        
        private bool ureeObservationFieldSpecified;
        
        private bool indicateurLiuField;
        
        private bool indicateurLiuFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int NumeroLactation
        {
            get
            {
                return this.numeroLactationField;
            }
            set
            {
                this.numeroLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int NumeroControle
        {
            get
            {
                return this.numeroControleField;
            }
            set
            {
                this.numeroControleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroControleSpecified
        {
            get
            {
                return this.numeroControleFieldSpecified;
            }
            set
            {
                this.numeroControleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TypeCodeEtatFemelle CodeEtatFemelle
        {
            get
            {
                return this.codeEtatFemelleField;
            }
            set
            {
                this.codeEtatFemelleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int LaitTotalObservation
        {
            get
            {
                return this.laitTotalObservationField;
            }
            set
            {
                this.laitTotalObservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaitTotalObservationSpecified
        {
            get
            {
                return this.laitTotalObservationFieldSpecified;
            }
            set
            {
                this.laitTotalObservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string CauseAbsenceTaux
        {
            get
            {
                return this.causeAbsenceTauxField;
            }
            set
            {
                this.causeAbsenceTauxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int TPObservation
        {
            get
            {
                return this.tPObservationField;
            }
            set
            {
                this.tPObservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TPObservationSpecified
        {
            get
            {
                return this.tPObservationFieldSpecified;
            }
            set
            {
                this.tPObservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int TBObservation
        {
            get
            {
                return this.tBObservationField;
            }
            set
            {
                this.tBObservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TBObservationSpecified
        {
            get
            {
                return this.tBObservationFieldSpecified;
            }
            set
            {
                this.tBObservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int CellulesObservation
        {
            get
            {
                return this.cellulesObservationField;
            }
            set
            {
                this.cellulesObservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CellulesObservationSpecified
        {
            get
            {
                return this.cellulesObservationFieldSpecified;
            }
            set
            {
                this.cellulesObservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int UreeObservation
        {
            get
            {
                return this.ureeObservationField;
            }
            set
            {
                this.ureeObservationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UreeObservationSpecified
        {
            get
            {
                return this.ureeObservationFieldSpecified;
            }
            set
            {
                this.ureeObservationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public bool IndicateurLiu
        {
            get
            {
                return this.indicateurLiuField;
            }
            set
            {
                this.indicateurLiuField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurLiuSpecified
        {
            get
            {
                return this.indicateurLiuFieldSpecified;
            }
            set
            {
                this.indicateurLiuFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeEtatFemelle:1")]
    public enum TypeCodeEtatFemelle
    {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        T,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MouvementULConstate
    {
        
        private System.DateTime dateEntreeField;
        
        private bool dateEntreeFieldSpecified;
        
        private System.DateTime dateSortieField;
        
        private bool dateSortieFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=0)]
        public System.DateTime DateEntree
        {
            get
            {
                return this.dateEntreeField;
            }
            set
            {
                this.dateEntreeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateEntreeSpecified
        {
            get
            {
                return this.dateEntreeFieldSpecified;
            }
            set
            {
                this.dateEntreeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=1)]
        public System.DateTime DateSortie
        {
            get
            {
                return this.dateSortieField;
            }
            set
            {
                this.dateSortieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSortieSpecified
        {
            get
            {
                return this.dateSortieFieldSpecified;
            }
            set
            {
                this.dateSortieFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PointageSevrageTiers
    {
        
        private TypeCodeSevragePointage codeSevragePointageField;
        
        private bool codeSevragePointageFieldSpecified;
        
        private int dessusEpauleCPVField;
        
        private bool dessusEpauleCPVFieldSpecified;
        
        private int largeurDosCPVField;
        
        private bool largeurDosCPVFieldSpecified;
        
        private int arrondiCulotteCPVField;
        
        private bool arrondiCulotteCPVFieldSpecified;
        
        private int largeurCulotteCPVField;
        
        private bool largeurCulotteCPVFieldSpecified;
        
        private int epaisseurDessusCPVField;
        
        private bool epaisseurDessusCPVFieldSpecified;
        
        private int grosseurCanonsCPVField;
        
        private bool grosseurCanonsCPVFieldSpecified;
        
        private int longueurDessusCPVField;
        
        private bool longueurDessusCPVFieldSpecified;
        
        private int longueurBassinCPVField;
        
        private bool longueurBassinCPVFieldSpecified;
        
        private int largeurHanchesCPVField;
        
        private bool largeurHanchesCPVFieldSpecified;
        
        private int developpementCPVField;
        
        private bool developpementCPVFieldSpecified;
        
        private int largeurMufleCPVField;
        
        private bool largeurMufleCPVFieldSpecified;
        
        private int aplombsAvantCPVField;
        
        private bool aplombsAvantCPVFieldSpecified;
        
        private int aplombsArriereCPVField;
        
        private bool aplombsArriereCPVFieldSpecified;
        
        private int rectitudeDessusCPVField;
        
        private bool rectitudeDessusCPVFieldSpecified;
        
        private int noteEtatPointageCPVField;
        
        private bool noteEtatPointageCPVFieldSpecified;
        
        private int profondeurPoitrineCPVField;
        
        private bool profondeurPoitrineCPVFieldSpecified;
        
        private int largeurPoitrineCPVField;
        
        private bool largeurPoitrineCPVFieldSpecified;
        
        private int largeurTrochantersCPVField;
        
        private bool largeurTrochantersCPVFieldSpecified;
        
        private int longueurCulotteCPVField;
        
        private bool longueurCulotteCPVFieldSpecified;
        
        private int developpementMusculaireCPVField;
        
        private bool developpementMusculaireCPVFieldSpecified;
        
        private int developpementSquelettiqueCPVField;
        
        private bool developpementSquelettiqueCPVFieldSpecified;
        
        private int aptitudeFonctionnelleCPVField;
        
        private bool aptitudeFonctionnelleCPVFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeSevragePointage CodeSevragePointage
        {
            get
            {
                return this.codeSevragePointageField;
            }
            set
            {
                this.codeSevragePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSevragePointageSpecified
        {
            get
            {
                return this.codeSevragePointageFieldSpecified;
            }
            set
            {
                this.codeSevragePointageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int DessusEpauleCPV
        {
            get
            {
                return this.dessusEpauleCPVField;
            }
            set
            {
                this.dessusEpauleCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DessusEpauleCPVSpecified
        {
            get
            {
                return this.dessusEpauleCPVFieldSpecified;
            }
            set
            {
                this.dessusEpauleCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int LargeurDosCPV
        {
            get
            {
                return this.largeurDosCPVField;
            }
            set
            {
                this.largeurDosCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurDosCPVSpecified
        {
            get
            {
                return this.largeurDosCPVFieldSpecified;
            }
            set
            {
                this.largeurDosCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int ArrondiCulotteCPV
        {
            get
            {
                return this.arrondiCulotteCPVField;
            }
            set
            {
                this.arrondiCulotteCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrondiCulotteCPVSpecified
        {
            get
            {
                return this.arrondiCulotteCPVFieldSpecified;
            }
            set
            {
                this.arrondiCulotteCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int LargeurCulotteCPV
        {
            get
            {
                return this.largeurCulotteCPVField;
            }
            set
            {
                this.largeurCulotteCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurCulotteCPVSpecified
        {
            get
            {
                return this.largeurCulotteCPVFieldSpecified;
            }
            set
            {
                this.largeurCulotteCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int EpaisseurDessusCPV
        {
            get
            {
                return this.epaisseurDessusCPVField;
            }
            set
            {
                this.epaisseurDessusCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EpaisseurDessusCPVSpecified
        {
            get
            {
                return this.epaisseurDessusCPVFieldSpecified;
            }
            set
            {
                this.epaisseurDessusCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int GrosseurCanonsCPV
        {
            get
            {
                return this.grosseurCanonsCPVField;
            }
            set
            {
                this.grosseurCanonsCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrosseurCanonsCPVSpecified
        {
            get
            {
                return this.grosseurCanonsCPVFieldSpecified;
            }
            set
            {
                this.grosseurCanonsCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int LongueurDessusCPV
        {
            get
            {
                return this.longueurDessusCPVField;
            }
            set
            {
                this.longueurDessusCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongueurDessusCPVSpecified
        {
            get
            {
                return this.longueurDessusCPVFieldSpecified;
            }
            set
            {
                this.longueurDessusCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int LongueurBassinCPV
        {
            get
            {
                return this.longueurBassinCPVField;
            }
            set
            {
                this.longueurBassinCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongueurBassinCPVSpecified
        {
            get
            {
                return this.longueurBassinCPVFieldSpecified;
            }
            set
            {
                this.longueurBassinCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int LargeurHanchesCPV
        {
            get
            {
                return this.largeurHanchesCPVField;
            }
            set
            {
                this.largeurHanchesCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurHanchesCPVSpecified
        {
            get
            {
                return this.largeurHanchesCPVFieldSpecified;
            }
            set
            {
                this.largeurHanchesCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int DeveloppementCPV
        {
            get
            {
                return this.developpementCPVField;
            }
            set
            {
                this.developpementCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeveloppementCPVSpecified
        {
            get
            {
                return this.developpementCPVFieldSpecified;
            }
            set
            {
                this.developpementCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int LargeurMufleCPV
        {
            get
            {
                return this.largeurMufleCPVField;
            }
            set
            {
                this.largeurMufleCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurMufleCPVSpecified
        {
            get
            {
                return this.largeurMufleCPVFieldSpecified;
            }
            set
            {
                this.largeurMufleCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int AplombsAvantCPV
        {
            get
            {
                return this.aplombsAvantCPVField;
            }
            set
            {
                this.aplombsAvantCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AplombsAvantCPVSpecified
        {
            get
            {
                return this.aplombsAvantCPVFieldSpecified;
            }
            set
            {
                this.aplombsAvantCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int AplombsArriereCPV
        {
            get
            {
                return this.aplombsArriereCPVField;
            }
            set
            {
                this.aplombsArriereCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AplombsArriereCPVSpecified
        {
            get
            {
                return this.aplombsArriereCPVFieldSpecified;
            }
            set
            {
                this.aplombsArriereCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public int RectitudeDessusCPV
        {
            get
            {
                return this.rectitudeDessusCPVField;
            }
            set
            {
                this.rectitudeDessusCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RectitudeDessusCPVSpecified
        {
            get
            {
                return this.rectitudeDessusCPVFieldSpecified;
            }
            set
            {
                this.rectitudeDessusCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int NoteEtatPointageCPV
        {
            get
            {
                return this.noteEtatPointageCPVField;
            }
            set
            {
                this.noteEtatPointageCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoteEtatPointageCPVSpecified
        {
            get
            {
                return this.noteEtatPointageCPVFieldSpecified;
            }
            set
            {
                this.noteEtatPointageCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int ProfondeurPoitrineCPV
        {
            get
            {
                return this.profondeurPoitrineCPVField;
            }
            set
            {
                this.profondeurPoitrineCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfondeurPoitrineCPVSpecified
        {
            get
            {
                return this.profondeurPoitrineCPVFieldSpecified;
            }
            set
            {
                this.profondeurPoitrineCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int LargeurPoitrineCPV
        {
            get
            {
                return this.largeurPoitrineCPVField;
            }
            set
            {
                this.largeurPoitrineCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurPoitrineCPVSpecified
        {
            get
            {
                return this.largeurPoitrineCPVFieldSpecified;
            }
            set
            {
                this.largeurPoitrineCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public int LargeurTrochantersCPV
        {
            get
            {
                return this.largeurTrochantersCPVField;
            }
            set
            {
                this.largeurTrochantersCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LargeurTrochantersCPVSpecified
        {
            get
            {
                return this.largeurTrochantersCPVFieldSpecified;
            }
            set
            {
                this.largeurTrochantersCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int LongueurCulotteCPV
        {
            get
            {
                return this.longueurCulotteCPVField;
            }
            set
            {
                this.longueurCulotteCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongueurCulotteCPVSpecified
        {
            get
            {
                return this.longueurCulotteCPVFieldSpecified;
            }
            set
            {
                this.longueurCulotteCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public int DeveloppementMusculaireCPV
        {
            get
            {
                return this.developpementMusculaireCPVField;
            }
            set
            {
                this.developpementMusculaireCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeveloppementMusculaireCPVSpecified
        {
            get
            {
                return this.developpementMusculaireCPVFieldSpecified;
            }
            set
            {
                this.developpementMusculaireCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int DeveloppementSquelettiqueCPV
        {
            get
            {
                return this.developpementSquelettiqueCPVField;
            }
            set
            {
                this.developpementSquelettiqueCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeveloppementSquelettiqueCPVSpecified
        {
            get
            {
                return this.developpementSquelettiqueCPVFieldSpecified;
            }
            set
            {
                this.developpementSquelettiqueCPVFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public int AptitudeFonctionnelleCPV
        {
            get
            {
                return this.aptitudeFonctionnelleCPVField;
            }
            set
            {
                this.aptitudeFonctionnelleCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AptitudeFonctionnelleCPVSpecified
        {
            get
            {
                return this.aptitudeFonctionnelleCPVFieldSpecified;
            }
            set
            {
                this.aptitudeFonctionnelleCPVFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementsAnimauxCPB : Evenement
    {
        
        private MiseEnPresence miseEnPresenceField;
        
        private Avortement avortementField;
        
        private Velage velageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MiseEnPresence MiseEnPresence
        {
            get
            {
                return this.miseEnPresenceField;
            }
            set
            {
                this.miseEnPresenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Avortement Avortement
        {
            get
            {
                return this.avortementField;
            }
            set
            {
                this.avortementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Velage Velage
        {
            get
            {
                return this.velageField;
            }
            set
            {
                this.velageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class EvenementsAnimauxCL : Evenement
    {
        
        private Mammite mammiteField;
        
        private DebutLactation debutLactationField;
        
        private ObservationLaitiereIndividuelle observationLaitiereField;
        
        private MouvementULConstate mouvementULConstateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Mammite Mammite
        {
            get
            {
                return this.mammiteField;
            }
            set
            {
                this.mammiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DebutLactation DebutLactation
        {
            get
            {
                return this.debutLactationField;
            }
            set
            {
                this.debutLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public ObservationLaitiereIndividuelle ObservationLaitiere
        {
            get
            {
                return this.observationLaitiereField;
            }
            set
            {
                this.observationLaitiereField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public MouvementULConstate MouvementULConstate
        {
            get
            {
                return this.mouvementULConstateField;
            }
            set
            {
                this.mouvementULConstateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DebutLactation
    {
        
        private int numeroLactationField;
        
        private TypeCodeEvenementDebutLactation evenementDebutLactationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int NumeroLactation
        {
            get
            {
                return this.numeroLactationField;
            }
            set
            {
                this.numeroLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TypeCodeEvenementDebutLactation EvenementDebutLactation
        {
            get
            {
                return this.evenementDebutLactationField;
            }
            set
            {
                this.evenementDebutLactationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PassageControleLaitier : Evenement
    {
        
        private ProtocoleControleLaitier protocoleControleLaitierField;
        
        private AgentTraite agentTraiteField;
        
        private int nombreTraitesPassageField;
        
        private bool nombreTraitesPassageFieldSpecified;
        
        private bool presenceRobotTraiteField;
        
        private bool presenceRobotTraiteFieldSpecified;
        
        private int nombreEchantillonsPrelevesField;
        
        private bool nombreEchantillonsPrelevesFieldSpecified;
        
        private HoraireTraite[] horaireTraiteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ProtocoleControleLaitier ProtocoleControleLaitier
        {
            get
            {
                return this.protocoleControleLaitierField;
            }
            set
            {
                this.protocoleControleLaitierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public AgentTraite AgentTraite
        {
            get
            {
                return this.agentTraiteField;
            }
            set
            {
                this.agentTraiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int NombreTraitesPassage
        {
            get
            {
                return this.nombreTraitesPassageField;
            }
            set
            {
                this.nombreTraitesPassageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreTraitesPassageSpecified
        {
            get
            {
                return this.nombreTraitesPassageFieldSpecified;
            }
            set
            {
                this.nombreTraitesPassageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool PresenceRobotTraite
        {
            get
            {
                return this.presenceRobotTraiteField;
            }
            set
            {
                this.presenceRobotTraiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PresenceRobotTraiteSpecified
        {
            get
            {
                return this.presenceRobotTraiteFieldSpecified;
            }
            set
            {
                this.presenceRobotTraiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int NombreEchantillonsPreleves
        {
            get
            {
                return this.nombreEchantillonsPrelevesField;
            }
            set
            {
                this.nombreEchantillonsPrelevesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreEchantillonsPrelevesSpecified
        {
            get
            {
                return this.nombreEchantillonsPrelevesFieldSpecified;
            }
            set
            {
                this.nombreEchantillonsPrelevesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HoraireTraite", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public HoraireTraite[] HoraireTraite
        {
            get
            {
                return this.horaireTraiteField;
            }
            set
            {
                this.horaireTraiteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DonneeElaboreeAnimal
    {
        
        private DonneesElaboreesAnimalCPB donneesElaboreesAnimalCPBField;
        
        private DonneesElaboreesAnimalCL donneesElaboreesAnimalCLField;
        
        private DonneesElaboreesAnimalCPV donneesElaboreesAnimalCPVField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public DonneesElaboreesAnimalCPB DonneesElaboreesAnimalCPB
        {
            get
            {
                return this.donneesElaboreesAnimalCPBField;
            }
            set
            {
                this.donneesElaboreesAnimalCPBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DonneesElaboreesAnimalCL DonneesElaboreesAnimalCL
        {
            get
            {
                return this.donneesElaboreesAnimalCLField;
            }
            set
            {
                this.donneesElaboreesAnimalCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public DonneesElaboreesAnimalCPV DonneesElaboreesAnimalCPV
        {
            get
            {
                return this.donneesElaboreesAnimalCPVField;
            }
            set
            {
                this.donneesElaboreesAnimalCPVField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DonneesElaboreesAnimalCPB
    {
        
        private Organisation createurField;
        
        private CertificationParente certificationParenteField;
        
        private System.DateTime dateElaborationField;
        
        private bool dateElaborationFieldSpecified;
        
        private bool codeSuppressionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation Createur
        {
            get
            {
                return this.createurField;
            }
            set
            {
                this.createurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public CertificationParente CertificationParente
        {
            get
            {
                return this.certificationParenteField;
            }
            set
            {
                this.certificationParenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=2)]
        public System.DateTime DateElaboration
        {
            get
            {
                return this.dateElaborationField;
            }
            set
            {
                this.dateElaborationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateElaborationSpecified
        {
            get
            {
                return this.dateElaborationFieldSpecified;
            }
            set
            {
                this.dateElaborationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DonneesElaboreesAnimalCL
    {
        
        private Organisation createurField;
        
        private Lactation lactationField;
        
        private IndexBovinLaitier indexBovinLaitierField;
        
        private System.DateTime dateElaborationField;
        
        private bool dateElaborationFieldSpecified;
        
        private bool codeSuppressionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation Createur
        {
            get
            {
                return this.createurField;
            }
            set
            {
                this.createurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Lactation Lactation
        {
            get
            {
                return this.lactationField;
            }
            set
            {
                this.lactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public IndexBovinLaitier IndexBovinLaitier
        {
            get
            {
                return this.indexBovinLaitierField;
            }
            set
            {
                this.indexBovinLaitierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=3)]
        public System.DateTime DateElaboration
        {
            get
            {
                return this.dateElaborationField;
            }
            set
            {
                this.dateElaborationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateElaborationSpecified
        {
            get
            {
                return this.dateElaborationFieldSpecified;
            }
            set
            {
                this.dateElaborationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Lactation
    {
        
        private int numeroLactationField;
        
        private System.DateTime dateLactationField;
        
        private TypeCodeEvenementDebutLactation evenementDebutLactationField;
        
        private TypeCodeStatutLactation etatLactationField;
        
        private string causeNonQualificationField;
        
        private string typeQualificationLactationField;
        
        private int dureeLactationField;
        
        private bool dureeLactationFieldSpecified;
        
        private int laitTotalLactationField;
        
        private bool laitTotalLactationFieldSpecified;
        
        private int mGTotalLactationField;
        
        private bool mGTotalLactationFieldSpecified;
        
        private int mPTotalLactationField;
        
        private bool mPTotalLactationFieldSpecified;
        
        private int tBTotalLactationField;
        
        private bool tBTotalLactationFieldSpecified;
        
        private int tPTotalLactationField;
        
        private bool tPTotalLactationFieldSpecified;
        
        private int laitReferenceField;
        
        private bool laitReferenceFieldSpecified;
        
        private int mGReferenceField;
        
        private bool mGReferenceFieldSpecified;
        
        private int mPReferenceField;
        
        private bool mPReferenceFieldSpecified;
        
        private int tBReferenceField;
        
        private bool tBReferenceFieldSpecified;
        
        private int tPReferenceField;
        
        private bool tPReferenceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int NumeroLactation
        {
            get
            {
                return this.numeroLactationField;
            }
            set
            {
                this.numeroLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=1)]
        public System.DateTime DateLactation
        {
            get
            {
                return this.dateLactationField;
            }
            set
            {
                this.dateLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TypeCodeEvenementDebutLactation EvenementDebutLactation
        {
            get
            {
                return this.evenementDebutLactationField;
            }
            set
            {
                this.evenementDebutLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public TypeCodeStatutLactation EtatLactation
        {
            get
            {
                return this.etatLactationField;
            }
            set
            {
                this.etatLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string CauseNonQualification
        {
            get
            {
                return this.causeNonQualificationField;
            }
            set
            {
                this.causeNonQualificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string TypeQualificationLactation
        {
            get
            {
                return this.typeQualificationLactationField;
            }
            set
            {
                this.typeQualificationLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int DureeLactation
        {
            get
            {
                return this.dureeLactationField;
            }
            set
            {
                this.dureeLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DureeLactationSpecified
        {
            get
            {
                return this.dureeLactationFieldSpecified;
            }
            set
            {
                this.dureeLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int LaitTotalLactation
        {
            get
            {
                return this.laitTotalLactationField;
            }
            set
            {
                this.laitTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaitTotalLactationSpecified
        {
            get
            {
                return this.laitTotalLactationFieldSpecified;
            }
            set
            {
                this.laitTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int MGTotalLactation
        {
            get
            {
                return this.mGTotalLactationField;
            }
            set
            {
                this.mGTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MGTotalLactationSpecified
        {
            get
            {
                return this.mGTotalLactationFieldSpecified;
            }
            set
            {
                this.mGTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int MPTotalLactation
        {
            get
            {
                return this.mPTotalLactationField;
            }
            set
            {
                this.mPTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MPTotalLactationSpecified
        {
            get
            {
                return this.mPTotalLactationFieldSpecified;
            }
            set
            {
                this.mPTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int TBTotalLactation
        {
            get
            {
                return this.tBTotalLactationField;
            }
            set
            {
                this.tBTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TBTotalLactationSpecified
        {
            get
            {
                return this.tBTotalLactationFieldSpecified;
            }
            set
            {
                this.tBTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int TPTotalLactation
        {
            get
            {
                return this.tPTotalLactationField;
            }
            set
            {
                this.tPTotalLactationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TPTotalLactationSpecified
        {
            get
            {
                return this.tPTotalLactationFieldSpecified;
            }
            set
            {
                this.tPTotalLactationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public int LaitReference
        {
            get
            {
                return this.laitReferenceField;
            }
            set
            {
                this.laitReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaitReferenceSpecified
        {
            get
            {
                return this.laitReferenceFieldSpecified;
            }
            set
            {
                this.laitReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int MGReference
        {
            get
            {
                return this.mGReferenceField;
            }
            set
            {
                this.mGReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MGReferenceSpecified
        {
            get
            {
                return this.mGReferenceFieldSpecified;
            }
            set
            {
                this.mGReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public int MPReference
        {
            get
            {
                return this.mPReferenceField;
            }
            set
            {
                this.mPReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MPReferenceSpecified
        {
            get
            {
                return this.mPReferenceFieldSpecified;
            }
            set
            {
                this.mPReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int TBReference
        {
            get
            {
                return this.tBReferenceField;
            }
            set
            {
                this.tBReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TBReferenceSpecified
        {
            get
            {
                return this.tBReferenceFieldSpecified;
            }
            set
            {
                this.tBReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int TPReference
        {
            get
            {
                return this.tPReferenceField;
            }
            set
            {
                this.tPReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TPReferenceSpecified
        {
            get
            {
                return this.tPReferenceFieldSpecified;
            }
            set
            {
                this.tPReferenceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexBovinLaitier
    {
        
        private string codeRaceIndexationField;
        
        private IndexProductionLaitiere indexProductionLaitiereField;
        
        private IndexCellules indexCellulesField;
        
        private IndexFertilite indexFertiliteField;
        
        private IndexLongevite indexLongeviteField;
        
        private IndexMammite indexMammiteField;
        
        private IndexFaciliteVelageNaissance indexFaciliteVelageNaissanceField;
        
        private IndexVitalite indexVitaliteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodeRaceIndexation
        {
            get
            {
                return this.codeRaceIndexationField;
            }
            set
            {
                this.codeRaceIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public IndexProductionLaitiere IndexProductionLaitiere
        {
            get
            {
                return this.indexProductionLaitiereField;
            }
            set
            {
                this.indexProductionLaitiereField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public IndexCellules IndexCellules
        {
            get
            {
                return this.indexCellulesField;
            }
            set
            {
                this.indexCellulesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public IndexFertilite IndexFertilite
        {
            get
            {
                return this.indexFertiliteField;
            }
            set
            {
                this.indexFertiliteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public IndexLongevite IndexLongevite
        {
            get
            {
                return this.indexLongeviteField;
            }
            set
            {
                this.indexLongeviteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public IndexMammite IndexMammite
        {
            get
            {
                return this.indexMammiteField;
            }
            set
            {
                this.indexMammiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public IndexFaciliteVelageNaissance IndexFaciliteVelageNaissance
        {
            get
            {
                return this.indexFaciliteVelageNaissanceField;
            }
            set
            {
                this.indexFaciliteVelageNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public IndexVitalite IndexVitalite
        {
            get
            {
                return this.indexVitaliteField;
            }
            set
            {
                this.indexVitaliteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexProductionLaitiere
    {
        
        private string referenceIndexField;
        
        private int cDINELField;
        
        private bool cDINELFieldSpecified;
        
        private int iNELField;
        
        private bool iNELFieldSpecified;
        
        private decimal indexTauxProteiqueField;
        
        private bool indexTauxProteiqueFieldSpecified;
        
        private decimal indexTauxButyreuxField;
        
        private bool indexTauxButyreuxFieldSpecified;
        
        private int indexMatiereGrasseField;
        
        private bool indexMatiereGrasseFieldSpecified;
        
        private int indexMatiereProteiqueField;
        
        private bool indexMatiereProteiqueFieldSpecified;
        
        private int indexLaitField;
        
        private bool indexLaitFieldSpecified;
        
        private int nombreFillesIndexLaitField;
        
        private bool nombreFillesIndexLaitFieldSpecified;
        
        private int nombreCheptelsIndexLaitField;
        
        private bool nombreCheptelsIndexLaitFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDINEL
        {
            get
            {
                return this.cDINELField;
            }
            set
            {
                this.cDINELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDINELSpecified
        {
            get
            {
                return this.cDINELFieldSpecified;
            }
            set
            {
                this.cDINELFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int INEL
        {
            get
            {
                return this.iNELField;
            }
            set
            {
                this.iNELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INELSpecified
        {
            get
            {
                return this.iNELFieldSpecified;
            }
            set
            {
                this.iNELFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal IndexTauxProteique
        {
            get
            {
                return this.indexTauxProteiqueField;
            }
            set
            {
                this.indexTauxProteiqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexTauxProteiqueSpecified
        {
            get
            {
                return this.indexTauxProteiqueFieldSpecified;
            }
            set
            {
                this.indexTauxProteiqueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal IndexTauxButyreux
        {
            get
            {
                return this.indexTauxButyreuxField;
            }
            set
            {
                this.indexTauxButyreuxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexTauxButyreuxSpecified
        {
            get
            {
                return this.indexTauxButyreuxFieldSpecified;
            }
            set
            {
                this.indexTauxButyreuxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int IndexMatiereGrasse
        {
            get
            {
                return this.indexMatiereGrasseField;
            }
            set
            {
                this.indexMatiereGrasseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexMatiereGrasseSpecified
        {
            get
            {
                return this.indexMatiereGrasseFieldSpecified;
            }
            set
            {
                this.indexMatiereGrasseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int IndexMatiereProteique
        {
            get
            {
                return this.indexMatiereProteiqueField;
            }
            set
            {
                this.indexMatiereProteiqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexMatiereProteiqueSpecified
        {
            get
            {
                return this.indexMatiereProteiqueFieldSpecified;
            }
            set
            {
                this.indexMatiereProteiqueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int IndexLait
        {
            get
            {
                return this.indexLaitField;
            }
            set
            {
                this.indexLaitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexLaitSpecified
        {
            get
            {
                return this.indexLaitFieldSpecified;
            }
            set
            {
                this.indexLaitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int NombreFillesIndexLait
        {
            get
            {
                return this.nombreFillesIndexLaitField;
            }
            set
            {
                this.nombreFillesIndexLaitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreFillesIndexLaitSpecified
        {
            get
            {
                return this.nombreFillesIndexLaitFieldSpecified;
            }
            set
            {
                this.nombreFillesIndexLaitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int NombreCheptelsIndexLait
        {
            get
            {
                return this.nombreCheptelsIndexLaitField;
            }
            set
            {
                this.nombreCheptelsIndexLaitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreCheptelsIndexLaitSpecified
        {
            get
            {
                return this.nombreCheptelsIndexLaitFieldSpecified;
            }
            set
            {
                this.nombreCheptelsIndexLaitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeTypeIndex:1")]
    public enum TypeCodeTypeIndex
    {
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexCellules
    {
        
        private string referenceIndexField;
        
        private int cDIndexCellulesField;
        
        private bool cDIndexCellulesFieldSpecified;
        
        private decimal indexCellulesElementaireField;
        
        private bool indexCellulesElementaireFieldSpecified;
        
        private int nombreFillesIndexCellulesField;
        
        private bool nombreFillesIndexCellulesFieldSpecified;
        
        private int nombreCheptelsIndexCellulesField;
        
        private bool nombreCheptelsIndexCellulesFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDIndexCellules
        {
            get
            {
                return this.cDIndexCellulesField;
            }
            set
            {
                this.cDIndexCellulesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexCellulesSpecified
        {
            get
            {
                return this.cDIndexCellulesFieldSpecified;
            }
            set
            {
                this.cDIndexCellulesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal IndexCellulesElementaire
        {
            get
            {
                return this.indexCellulesElementaireField;
            }
            set
            {
                this.indexCellulesElementaireField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexCellulesElementaireSpecified
        {
            get
            {
                return this.indexCellulesElementaireFieldSpecified;
            }
            set
            {
                this.indexCellulesElementaireFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int NombreFillesIndexCellules
        {
            get
            {
                return this.nombreFillesIndexCellulesField;
            }
            set
            {
                this.nombreFillesIndexCellulesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreFillesIndexCellulesSpecified
        {
            get
            {
                return this.nombreFillesIndexCellulesFieldSpecified;
            }
            set
            {
                this.nombreFillesIndexCellulesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int NombreCheptelsIndexCellules
        {
            get
            {
                return this.nombreCheptelsIndexCellulesField;
            }
            set
            {
                this.nombreCheptelsIndexCellulesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreCheptelsIndexCellulesSpecified
        {
            get
            {
                return this.nombreCheptelsIndexCellulesFieldSpecified;
            }
            set
            {
                this.nombreCheptelsIndexCellulesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexFertilite
    {
        
        private string referenceIndexField;
        
        private int cDIndexFertiliteElementaireField;
        
        private bool cDIndexFertiliteElementaireFieldSpecified;
        
        private decimal indexFertiliteElementaireField;
        
        private bool indexFertiliteElementaireFieldSpecified;
        
        private int cDIndexFertiliteGenissesField;
        
        private bool cDIndexFertiliteGenissesFieldSpecified;
        
        private decimal indexFertiliteGenissesField;
        
        private bool indexFertiliteGenissesFieldSpecified;
        
        private int cDIndexFertiliteVelageIAField;
        
        private bool cDIndexFertiliteVelageIAFieldSpecified;
        
        private decimal indexFertiliteVelageIAField;
        
        private bool indexFertiliteVelageIAFieldSpecified;
        
        private int cDIndexFertiliteSyntheseField;
        
        private bool cDIndexFertiliteSyntheseFieldSpecified;
        
        private decimal indexFertiliteSyntheseField;
        
        private bool indexFertiliteSyntheseFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDIndexFertiliteElementaire
        {
            get
            {
                return this.cDIndexFertiliteElementaireField;
            }
            set
            {
                this.cDIndexFertiliteElementaireField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexFertiliteElementaireSpecified
        {
            get
            {
                return this.cDIndexFertiliteElementaireFieldSpecified;
            }
            set
            {
                this.cDIndexFertiliteElementaireFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal IndexFertiliteElementaire
        {
            get
            {
                return this.indexFertiliteElementaireField;
            }
            set
            {
                this.indexFertiliteElementaireField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexFertiliteElementaireSpecified
        {
            get
            {
                return this.indexFertiliteElementaireFieldSpecified;
            }
            set
            {
                this.indexFertiliteElementaireFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int CDIndexFertiliteGenisses
        {
            get
            {
                return this.cDIndexFertiliteGenissesField;
            }
            set
            {
                this.cDIndexFertiliteGenissesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexFertiliteGenissesSpecified
        {
            get
            {
                return this.cDIndexFertiliteGenissesFieldSpecified;
            }
            set
            {
                this.cDIndexFertiliteGenissesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal IndexFertiliteGenisses
        {
            get
            {
                return this.indexFertiliteGenissesField;
            }
            set
            {
                this.indexFertiliteGenissesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexFertiliteGenissesSpecified
        {
            get
            {
                return this.indexFertiliteGenissesFieldSpecified;
            }
            set
            {
                this.indexFertiliteGenissesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int CDIndexFertiliteVelageIA
        {
            get
            {
                return this.cDIndexFertiliteVelageIAField;
            }
            set
            {
                this.cDIndexFertiliteVelageIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexFertiliteVelageIASpecified
        {
            get
            {
                return this.cDIndexFertiliteVelageIAFieldSpecified;
            }
            set
            {
                this.cDIndexFertiliteVelageIAFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal IndexFertiliteVelageIA
        {
            get
            {
                return this.indexFertiliteVelageIAField;
            }
            set
            {
                this.indexFertiliteVelageIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexFertiliteVelageIASpecified
        {
            get
            {
                return this.indexFertiliteVelageIAFieldSpecified;
            }
            set
            {
                this.indexFertiliteVelageIAFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int CDIndexFertiliteSynthese
        {
            get
            {
                return this.cDIndexFertiliteSyntheseField;
            }
            set
            {
                this.cDIndexFertiliteSyntheseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexFertiliteSyntheseSpecified
        {
            get
            {
                return this.cDIndexFertiliteSyntheseFieldSpecified;
            }
            set
            {
                this.cDIndexFertiliteSyntheseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal IndexFertiliteSynthese
        {
            get
            {
                return this.indexFertiliteSyntheseField;
            }
            set
            {
                this.indexFertiliteSyntheseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexFertiliteSyntheseSpecified
        {
            get
            {
                return this.indexFertiliteSyntheseFieldSpecified;
            }
            set
            {
                this.indexFertiliteSyntheseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexLongevite
    {
        
        private string referenceIndexField;
        
        private int cDIndexLongeviteFonctionnelleField;
        
        private bool cDIndexLongeviteFonctionnelleFieldSpecified;
        
        private decimal indexLongeviteFonctionnelleField;
        
        private bool indexLongeviteFonctionnelleFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDIndexLongeviteFonctionnelle
        {
            get
            {
                return this.cDIndexLongeviteFonctionnelleField;
            }
            set
            {
                this.cDIndexLongeviteFonctionnelleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexLongeviteFonctionnelleSpecified
        {
            get
            {
                return this.cDIndexLongeviteFonctionnelleFieldSpecified;
            }
            set
            {
                this.cDIndexLongeviteFonctionnelleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal IndexLongeviteFonctionnelle
        {
            get
            {
                return this.indexLongeviteFonctionnelleField;
            }
            set
            {
                this.indexLongeviteFonctionnelleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexLongeviteFonctionnelleSpecified
        {
            get
            {
                return this.indexLongeviteFonctionnelleFieldSpecified;
            }
            set
            {
                this.indexLongeviteFonctionnelleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexMammite
    {
        
        private string referenceIndexField;
        
        private int cDIndexMammiteCliniqueField;
        
        private bool cDIndexMammiteCliniqueFieldSpecified;
        
        private decimal indexMammiteCliniqueField;
        
        private bool indexMammiteCliniqueFieldSpecified;
        
        private int cDIndexSanteMamelleField;
        
        private bool cDIndexSanteMamelleFieldSpecified;
        
        private decimal indexSanteMamelleField;
        
        private bool indexSanteMamelleFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDIndexMammiteClinique
        {
            get
            {
                return this.cDIndexMammiteCliniqueField;
            }
            set
            {
                this.cDIndexMammiteCliniqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexMammiteCliniqueSpecified
        {
            get
            {
                return this.cDIndexMammiteCliniqueFieldSpecified;
            }
            set
            {
                this.cDIndexMammiteCliniqueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal IndexMammiteClinique
        {
            get
            {
                return this.indexMammiteCliniqueField;
            }
            set
            {
                this.indexMammiteCliniqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexMammiteCliniqueSpecified
        {
            get
            {
                return this.indexMammiteCliniqueFieldSpecified;
            }
            set
            {
                this.indexMammiteCliniqueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int CDIndexSanteMamelle
        {
            get
            {
                return this.cDIndexSanteMamelleField;
            }
            set
            {
                this.cDIndexSanteMamelleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexSanteMamelleSpecified
        {
            get
            {
                return this.cDIndexSanteMamelleFieldSpecified;
            }
            set
            {
                this.cDIndexSanteMamelleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal IndexSanteMamelle
        {
            get
            {
                return this.indexSanteMamelleField;
            }
            set
            {
                this.indexSanteMamelleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexSanteMamelleSpecified
        {
            get
            {
                return this.indexSanteMamelleFieldSpecified;
            }
            set
            {
                this.indexSanteMamelleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexFaciliteVelageNaissance
    {
        
        private string referenceIndexField;
        
        private int cDIndexFaciliteNaissanceField;
        
        private bool cDIndexFaciliteNaissanceFieldSpecified;
        
        private int indexFaciliteNaissanceField;
        
        private bool indexFaciliteNaissanceFieldSpecified;
        
        private int cDIndexFaciliteVelageField;
        
        private bool cDIndexFaciliteVelageFieldSpecified;
        
        private int indexFaciliteVelageField;
        
        private bool indexFaciliteVelageFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDIndexFaciliteNaissance
        {
            get
            {
                return this.cDIndexFaciliteNaissanceField;
            }
            set
            {
                this.cDIndexFaciliteNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexFaciliteNaissanceSpecified
        {
            get
            {
                return this.cDIndexFaciliteNaissanceFieldSpecified;
            }
            set
            {
                this.cDIndexFaciliteNaissanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int IndexFaciliteNaissance
        {
            get
            {
                return this.indexFaciliteNaissanceField;
            }
            set
            {
                this.indexFaciliteNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexFaciliteNaissanceSpecified
        {
            get
            {
                return this.indexFaciliteNaissanceFieldSpecified;
            }
            set
            {
                this.indexFaciliteNaissanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int CDIndexFaciliteVelage
        {
            get
            {
                return this.cDIndexFaciliteVelageField;
            }
            set
            {
                this.cDIndexFaciliteVelageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexFaciliteVelageSpecified
        {
            get
            {
                return this.cDIndexFaciliteVelageFieldSpecified;
            }
            set
            {
                this.cDIndexFaciliteVelageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int IndexFaciliteVelage
        {
            get
            {
                return this.indexFaciliteVelageField;
            }
            set
            {
                this.indexFaciliteVelageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexFaciliteVelageSpecified
        {
            get
            {
                return this.indexFaciliteVelageFieldSpecified;
            }
            set
            {
                this.indexFaciliteVelageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexVitalite
    {
        
        private string referenceIndexField;
        
        private int cDIndexVitaliteNaissanceField;
        
        private bool cDIndexVitaliteNaissanceFieldSpecified;
        
        private int indexVitaliteNaissanceField;
        
        private bool indexVitaliteNaissanceFieldSpecified;
        
        private int cDIndexVitaliteVelageField;
        
        private bool cDIndexVitaliteVelageFieldSpecified;
        
        private int indexVitaliteVelageField;
        
        private bool indexVitaliteVelageFieldSpecified;
        
        private TypeCodeTypeIndex typeIndexField;
        
        private bool typeIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ReferenceIndex
        {
            get
            {
                return this.referenceIndexField;
            }
            set
            {
                this.referenceIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CDIndexVitaliteNaissance
        {
            get
            {
                return this.cDIndexVitaliteNaissanceField;
            }
            set
            {
                this.cDIndexVitaliteNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexVitaliteNaissanceSpecified
        {
            get
            {
                return this.cDIndexVitaliteNaissanceFieldSpecified;
            }
            set
            {
                this.cDIndexVitaliteNaissanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int IndexVitaliteNaissance
        {
            get
            {
                return this.indexVitaliteNaissanceField;
            }
            set
            {
                this.indexVitaliteNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexVitaliteNaissanceSpecified
        {
            get
            {
                return this.indexVitaliteNaissanceFieldSpecified;
            }
            set
            {
                this.indexVitaliteNaissanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int CDIndexVitaliteVelage
        {
            get
            {
                return this.cDIndexVitaliteVelageField;
            }
            set
            {
                this.cDIndexVitaliteVelageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIndexVitaliteVelageSpecified
        {
            get
            {
                return this.cDIndexVitaliteVelageFieldSpecified;
            }
            set
            {
                this.cDIndexVitaliteVelageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int IndexVitaliteVelage
        {
            get
            {
                return this.indexVitaliteVelageField;
            }
            set
            {
                this.indexVitaliteVelageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndexVitaliteVelageSpecified
        {
            get
            {
                return this.indexVitaliteVelageFieldSpecified;
            }
            set
            {
                this.indexVitaliteVelageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public TypeCodeTypeIndex TypeIndex
        {
            get
            {
                return this.typeIndexField;
            }
            set
            {
                this.typeIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeIndexSpecified
        {
            get
            {
                return this.typeIndexFieldSpecified;
            }
            set
            {
                this.typeIndexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DonneesElaboreesAnimalCPV
    {
        
        private Organisation createurField;
        
        private PoidsAgeType poidsAgeTypeField;
        
        private IndexIBOVAL indexIBOVALField;
        
        private IndexCDABJeunesBovins indexCDABJeunesBovinsField;
        
        private IndexCDFaciliteNaissance indexCDFaciliteNaissanceField;
        
        private IndexCDMuscularitePrecoce indexCDMuscularitePrecoceField;
        
        private IndexCDQualitesMaternelles indexCDQualitesMaternellesField;
        
        private IndexCDVeauBoucherie indexCDVeauBoucherieField;
        
        private IndexControleStationsSECI indexControleStationsSECIField;
        
        private System.DateTime dateElaborationField;
        
        private bool dateElaborationFieldSpecified;
        
        private bool codeSuppressionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation Createur
        {
            get
            {
                return this.createurField;
            }
            set
            {
                this.createurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public PoidsAgeType PoidsAgeType
        {
            get
            {
                return this.poidsAgeTypeField;
            }
            set
            {
                this.poidsAgeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public IndexIBOVAL IndexIBOVAL
        {
            get
            {
                return this.indexIBOVALField;
            }
            set
            {
                this.indexIBOVALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public IndexCDABJeunesBovins IndexCDABJeunesBovins
        {
            get
            {
                return this.indexCDABJeunesBovinsField;
            }
            set
            {
                this.indexCDABJeunesBovinsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public IndexCDFaciliteNaissance IndexCDFaciliteNaissance
        {
            get
            {
                return this.indexCDFaciliteNaissanceField;
            }
            set
            {
                this.indexCDFaciliteNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public IndexCDMuscularitePrecoce IndexCDMuscularitePrecoce
        {
            get
            {
                return this.indexCDMuscularitePrecoceField;
            }
            set
            {
                this.indexCDMuscularitePrecoceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public IndexCDQualitesMaternelles IndexCDQualitesMaternelles
        {
            get
            {
                return this.indexCDQualitesMaternellesField;
            }
            set
            {
                this.indexCDQualitesMaternellesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public IndexCDVeauBoucherie IndexCDVeauBoucherie
        {
            get
            {
                return this.indexCDVeauBoucherieField;
            }
            set
            {
                this.indexCDVeauBoucherieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public IndexControleStationsSECI IndexControleStationsSECI
        {
            get
            {
                return this.indexControleStationsSECIField;
            }
            set
            {
                this.indexControleStationsSECIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=9)]
        public System.DateTime DateElaboration
        {
            get
            {
                return this.dateElaborationField;
            }
            set
            {
                this.dateElaborationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateElaborationSpecified
        {
            get
            {
                return this.dateElaborationFieldSpecified;
            }
            set
            {
                this.dateElaborationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class PoidsAgeType
    {
        
        private string codePATField;
        
        private int pATField;
        
        private string indicateurUtilisationPoidsNaissanceField;
        
        private string indicateurExtrapolation60JoursField;
        
        private string indicateurUtilisationPeseeSortieField;
        
        private System.DateTime datePremierePeseeUtiliseeField;
        
        private bool datePremierePeseeUtiliseeFieldSpecified;
        
        private System.DateTime dateDeuxiemePeseeUtiliseeField;
        
        private bool dateDeuxiemePeseeUtiliseeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodePAT
        {
            get
            {
                return this.codePATField;
            }
            set
            {
                this.codePATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int PAT
        {
            get
            {
                return this.pATField;
            }
            set
            {
                this.pATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string IndicateurUtilisationPoidsNaissance
        {
            get
            {
                return this.indicateurUtilisationPoidsNaissanceField;
            }
            set
            {
                this.indicateurUtilisationPoidsNaissanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string IndicateurExtrapolation60Jours
        {
            get
            {
                return this.indicateurExtrapolation60JoursField;
            }
            set
            {
                this.indicateurExtrapolation60JoursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string IndicateurUtilisationPeseeSortie
        {
            get
            {
                return this.indicateurUtilisationPeseeSortieField;
            }
            set
            {
                this.indicateurUtilisationPeseeSortieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=5)]
        public System.DateTime DatePremierePeseeUtilisee
        {
            get
            {
                return this.datePremierePeseeUtiliseeField;
            }
            set
            {
                this.datePremierePeseeUtiliseeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatePremierePeseeUtiliseeSpecified
        {
            get
            {
                return this.datePremierePeseeUtiliseeFieldSpecified;
            }
            set
            {
                this.datePremierePeseeUtiliseeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=6)]
        public System.DateTime DateDeuxiemePeseeUtilisee
        {
            get
            {
                return this.dateDeuxiemePeseeUtiliseeField;
            }
            set
            {
                this.dateDeuxiemePeseeUtiliseeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateDeuxiemePeseeUtiliseeSpecified
        {
            get
            {
                return this.dateDeuxiemePeseeUtiliseeFieldSpecified;
            }
            set
            {
                this.dateDeuxiemePeseeUtiliseeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexIBOVAL
    {
        
        private IBOVALCarcasse iBOVALCarcasseField;
        
        private IBOVALPostePointage iBOVALPostePointageField;
        
        private IBOVALSevrage[] iBOVALSevrageField;
        
        private IBOVALCroissancePostSevrage[] iBOVALCroissancePostSevrageField;
        
        private IBOVALMorphologiePostSevrage[] iBOVALMorphologiePostSevrageField;
        
        private IBOVALVieProductive[] iBOVALVieProductiveField;
        
        private string codeRaceIndexationField;
        
        private string anneeIndexationField;
        
        private string rangIndexationField;
        
        private string[] libelleBaseReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public IBOVALCarcasse IBOVALCarcasse
        {
            get
            {
                return this.iBOVALCarcasseField;
            }
            set
            {
                this.iBOVALCarcasseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public IBOVALPostePointage IBOVALPostePointage
        {
            get
            {
                return this.iBOVALPostePointageField;
            }
            set
            {
                this.iBOVALPostePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IBOVALSevrage", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public IBOVALSevrage[] IBOVALSevrage
        {
            get
            {
                return this.iBOVALSevrageField;
            }
            set
            {
                this.iBOVALSevrageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IBOVALCroissancePostSevrage", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public IBOVALCroissancePostSevrage[] IBOVALCroissancePostSevrage
        {
            get
            {
                return this.iBOVALCroissancePostSevrageField;
            }
            set
            {
                this.iBOVALCroissancePostSevrageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IBOVALMorphologiePostSevrage", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public IBOVALMorphologiePostSevrage[] IBOVALMorphologiePostSevrage
        {
            get
            {
                return this.iBOVALMorphologiePostSevrageField;
            }
            set
            {
                this.iBOVALMorphologiePostSevrageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IBOVALVieProductive", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public IBOVALVieProductive[] IBOVALVieProductive
        {
            get
            {
                return this.iBOVALVieProductiveField;
            }
            set
            {
                this.iBOVALVieProductiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string CodeRaceIndexation
        {
            get
            {
                return this.codeRaceIndexationField;
            }
            set
            {
                this.codeRaceIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string AnneeIndexation
        {
            get
            {
                return this.anneeIndexationField;
            }
            set
            {
                this.anneeIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string RangIndexation
        {
            get
            {
                return this.rangIndexationField;
            }
            set
            {
                this.rangIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LibelleBaseReference", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string[] LibelleBaseReference
        {
            get
            {
                return this.libelleBaseReferenceField;
            }
            set
            {
                this.libelleBaseReferenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IBOVALCarcasse
    {
        
        private int iCRCjbfBase100Field;
        
        private bool iCRCjbfBase100FieldSpecified;
        
        private decimal cDCRCjbfField;
        
        private bool cDCRCjbfFieldSpecified;
        
        private int cONFjbfField;
        
        private bool cONFjbfFieldSpecified;
        
        private decimal cDCONFjbfField;
        
        private bool cDCONFjbfFieldSpecified;
        
        private decimal iABjbfEurosField;
        
        private bool iABjbfEurosFieldSpecified;
        
        private int iABjbfBase100Field;
        
        private bool iABjbfBase100FieldSpecified;
        
        private decimal cDIABjbfField;
        
        private bool cDIABjbfFieldSpecified;
        
        private int nombrePCUtilisesField;
        
        private bool nombrePCUtilisesFieldSpecified;
        
        private int nombreConformationsUtiliseesField;
        
        private bool nombreConformationsUtiliseesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int ICRCjbfBase100
        {
            get
            {
                return this.iCRCjbfBase100Field;
            }
            set
            {
                this.iCRCjbfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ICRCjbfBase100Specified
        {
            get
            {
                return this.iCRCjbfBase100FieldSpecified;
            }
            set
            {
                this.iCRCjbfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal CDCRCjbf
        {
            get
            {
                return this.cDCRCjbfField;
            }
            set
            {
                this.cDCRCjbfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRCjbfSpecified
        {
            get
            {
                return this.cDCRCjbfFieldSpecified;
            }
            set
            {
                this.cDCRCjbfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int CONFjbf
        {
            get
            {
                return this.cONFjbfField;
            }
            set
            {
                this.cONFjbfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CONFjbfSpecified
        {
            get
            {
                return this.cONFjbfFieldSpecified;
            }
            set
            {
                this.cONFjbfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal CDCONFjbf
        {
            get
            {
                return this.cDCONFjbfField;
            }
            set
            {
                this.cDCONFjbfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCONFjbfSpecified
        {
            get
            {
                return this.cDCONFjbfFieldSpecified;
            }
            set
            {
                this.cDCONFjbfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal IABjbfEuros
        {
            get
            {
                return this.iABjbfEurosField;
            }
            set
            {
                this.iABjbfEurosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABjbfEurosSpecified
        {
            get
            {
                return this.iABjbfEurosFieldSpecified;
            }
            set
            {
                this.iABjbfEurosFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int IABjbfBase100
        {
            get
            {
                return this.iABjbfBase100Field;
            }
            set
            {
                this.iABjbfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABjbfBase100Specified
        {
            get
            {
                return this.iABjbfBase100FieldSpecified;
            }
            set
            {
                this.iABjbfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDIABjbf
        {
            get
            {
                return this.cDIABjbfField;
            }
            set
            {
                this.cDIABjbfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIABjbfSpecified
        {
            get
            {
                return this.cDIABjbfFieldSpecified;
            }
            set
            {
                this.cDIABjbfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int NombrePCUtilises
        {
            get
            {
                return this.nombrePCUtilisesField;
            }
            set
            {
                this.nombrePCUtilisesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombrePCUtilisesSpecified
        {
            get
            {
                return this.nombrePCUtilisesFieldSpecified;
            }
            set
            {
                this.nombrePCUtilisesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int NombreConformationsUtilisees
        {
            get
            {
                return this.nombreConformationsUtiliseesField;
            }
            set
            {
                this.nombreConformationsUtiliseesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreConformationsUtiliseesSpecified
        {
            get
            {
                return this.nombreConformationsUtiliseesFieldSpecified;
            }
            set
            {
                this.nombreConformationsUtiliseesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IBOVALPostePointage
    {
        
        private string dEEse3Field;
        
        private string lADse3Field;
        
        private string lACse3Field;
        
        private string aRCse3Field;
        
        private string ePDse3Field;
        
        private string gRCse3Field;
        
        private string lODse3Field;
        
        private string lOBse3Field;
        
        private string lAHse3Field;
        
        private string dEVse3Field;
        
        private string tETse3Field;
        
        private string aAVse3Field;
        
        private string aARse3Field;
        
        private string rEDse3Field;
        
        private string eTAse3Field;
        
        private string lOCse3Field;
        
        private string lATse3Field;
        
        private string lAPse3Field;
        
        private string pPOse3Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string DEEse3
        {
            get
            {
                return this.dEEse3Field;
            }
            set
            {
                this.dEEse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string LADse3
        {
            get
            {
                return this.lADse3Field;
            }
            set
            {
                this.lADse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string LACse3
        {
            get
            {
                return this.lACse3Field;
            }
            set
            {
                this.lACse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string ARCse3
        {
            get
            {
                return this.aRCse3Field;
            }
            set
            {
                this.aRCse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string EPDse3
        {
            get
            {
                return this.ePDse3Field;
            }
            set
            {
                this.ePDse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string GRCse3
        {
            get
            {
                return this.gRCse3Field;
            }
            set
            {
                this.gRCse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string LODse3
        {
            get
            {
                return this.lODse3Field;
            }
            set
            {
                this.lODse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string LOBse3
        {
            get
            {
                return this.lOBse3Field;
            }
            set
            {
                this.lOBse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string LAHse3
        {
            get
            {
                return this.lAHse3Field;
            }
            set
            {
                this.lAHse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string DEVse3
        {
            get
            {
                return this.dEVse3Field;
            }
            set
            {
                this.dEVse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string TETse3
        {
            get
            {
                return this.tETse3Field;
            }
            set
            {
                this.tETse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string AAVse3
        {
            get
            {
                return this.aAVse3Field;
            }
            set
            {
                this.aAVse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string AARse3
        {
            get
            {
                return this.aARse3Field;
            }
            set
            {
                this.aARse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string REDse3
        {
            get
            {
                return this.rEDse3Field;
            }
            set
            {
                this.rEDse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string ETAse3
        {
            get
            {
                return this.eTAse3Field;
            }
            set
            {
                this.eTAse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string LOCse3
        {
            get
            {
                return this.lOCse3Field;
            }
            set
            {
                this.lOCse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string LATse3
        {
            get
            {
                return this.lATse3Field;
            }
            set
            {
                this.lATse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string LAPse3
        {
            get
            {
                return this.lAPse3Field;
            }
            set
            {
                this.lAPse3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string PPOse3
        {
            get
            {
                return this.pPOse3Field;
            }
            set
            {
                this.pPOse3Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IBOVALSevrage
    {
        
        private TypeCodeTypeBaseIndexation typeBaseIndexationField;
        
        private bool typeBaseIndexationFieldSpecified;
        
        private int iFNAISField;
        
        private bool iFNAISFieldSpecified;
        
        private decimal cDIFNAISField;
        
        private bool cDIFNAISFieldSpecified;
        
        private decimal cRsevKgField;
        
        private bool cRsevKgFieldSpecified;
        
        private int cRsevBase100Field;
        
        private bool cRsevBase100FieldSpecified;
        
        private decimal cDCRsevField;
        
        private bool cDCRsevFieldSpecified;
        
        private decimal dMsevPointsField;
        
        private bool dMsevPointsFieldSpecified;
        
        private int dMsevBase100Field;
        
        private bool dMsevBase100FieldSpecified;
        
        private decimal cDDMsevField;
        
        private bool cDDMsevFieldSpecified;
        
        private decimal dSsevPointsField;
        
        private bool dSsevPointsFieldSpecified;
        
        private int dSsevBase100Field;
        
        private bool dSsevBase100FieldSpecified;
        
        private decimal cDDSsevField;
        
        private bool cDDSsevFieldSpecified;
        
        private decimal aLaitKgField;
        
        private bool aLaitKgFieldSpecified;
        
        private int aLaitBase100Field;
        
        private bool aLaitBase100FieldSpecified;
        
        private decimal cDALaitField;
        
        private bool cDALaitFieldSpecified;
        
        private decimal mERPsevKgField;
        
        private bool mERPsevKgFieldSpecified;
        
        private int mERPsevBase100Field;
        
        private bool mERPsevBase100FieldSpecified;
        
        private decimal cDMERPsevField;
        
        private bool cDMERPsevFieldSpecified;
        
        private int iSEVRField;
        
        private bool iSEVRFieldSpecified;
        
        private decimal cDISEVRField;
        
        private bool cDISEVRFieldSpecified;
        
        private int iVMATField;
        
        private bool iVMATFieldSpecified;
        
        private decimal cDIVMATField;
        
        private bool cDIVMATFieldSpecified;
        
        private int aVELField;
        
        private bool aVELFieldSpecified;
        
        private decimal cDAVELField;
        
        private bool cDAVELFieldSpecified;
        
        private int fOSsevBase100Field;
        
        private bool fOSsevBase100FieldSpecified;
        
        private decimal cDFOSsevField;
        
        private bool cDFOSsevFieldSpecified;
        
        private TypeCodeIndexAscendance indicateurIndexAscendanceField;
        
        private bool indicateurIndexAscendanceFieldSpecified;
        
        private int nombreCampagnesUtilisationField;
        
        private bool nombreCampagnesUtilisationFieldSpecified;
        
        private int nombreProduitsUtilisesField;
        
        private bool nombreProduitsUtilisesFieldSpecified;
        
        private int nombreProduitsConnectesUtilisesField;
        
        private bool nombreProduitsConnectesUtilisesFieldSpecified;
        
        private int nombreTroupeauxField;
        
        private bool nombreTroupeauxFieldSpecified;
        
        private int nombreTroupeauxCampagnesField;
        
        private bool nombreTroupeauxCampagnesFieldSpecified;
        
        private int nombreTroupeauxCampagnesConnectesField;
        
        private bool nombreTroupeauxCampagnesConnectesFieldSpecified;
        
        private int nombreFillesAvecProduitField;
        
        private bool nombreFillesAvecProduitFieldSpecified;
        
        private int nombrePetitsProduitsField;
        
        private bool nombrePetitsProduitsFieldSpecified;
        
        private int nombrePetitsProduitsConnectesField;
        
        private bool nombrePetitsProduitsConnectesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeTypeBaseIndexation TypeBaseIndexation
        {
            get
            {
                return this.typeBaseIndexationField;
            }
            set
            {
                this.typeBaseIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeBaseIndexationSpecified
        {
            get
            {
                return this.typeBaseIndexationFieldSpecified;
            }
            set
            {
                this.typeBaseIndexationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int IFNAIS
        {
            get
            {
                return this.iFNAISField;
            }
            set
            {
                this.iFNAISField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IFNAISSpecified
        {
            get
            {
                return this.iFNAISFieldSpecified;
            }
            set
            {
                this.iFNAISFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDIFNAIS
        {
            get
            {
                return this.cDIFNAISField;
            }
            set
            {
                this.cDIFNAISField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIFNAISSpecified
        {
            get
            {
                return this.cDIFNAISFieldSpecified;
            }
            set
            {
                this.cDIFNAISFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal CRsevKg
        {
            get
            {
                return this.cRsevKgField;
            }
            set
            {
                this.cRsevKgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRsevKgSpecified
        {
            get
            {
                return this.cRsevKgFieldSpecified;
            }
            set
            {
                this.cRsevKgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int CRsevBase100
        {
            get
            {
                return this.cRsevBase100Field;
            }
            set
            {
                this.cRsevBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRsevBase100Specified
        {
            get
            {
                return this.cRsevBase100FieldSpecified;
            }
            set
            {
                this.cRsevBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public decimal CDCRsev
        {
            get
            {
                return this.cDCRsevField;
            }
            set
            {
                this.cDCRsevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRsevSpecified
        {
            get
            {
                return this.cDCRsevFieldSpecified;
            }
            set
            {
                this.cDCRsevFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal DMsevPoints
        {
            get
            {
                return this.dMsevPointsField;
            }
            set
            {
                this.dMsevPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMsevPointsSpecified
        {
            get
            {
                return this.dMsevPointsFieldSpecified;
            }
            set
            {
                this.dMsevPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int DMsevBase100
        {
            get
            {
                return this.dMsevBase100Field;
            }
            set
            {
                this.dMsevBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMsevBase100Specified
        {
            get
            {
                return this.dMsevBase100FieldSpecified;
            }
            set
            {
                this.dMsevBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal CDDMsev
        {
            get
            {
                return this.cDDMsevField;
            }
            set
            {
                this.cDDMsevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDMsevSpecified
        {
            get
            {
                return this.cDDMsevFieldSpecified;
            }
            set
            {
                this.cDDMsevFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public decimal DSsevPoints
        {
            get
            {
                return this.dSsevPointsField;
            }
            set
            {
                this.dSsevPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSsevPointsSpecified
        {
            get
            {
                return this.dSsevPointsFieldSpecified;
            }
            set
            {
                this.dSsevPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int DSsevBase100
        {
            get
            {
                return this.dSsevBase100Field;
            }
            set
            {
                this.dSsevBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSsevBase100Specified
        {
            get
            {
                return this.dSsevBase100FieldSpecified;
            }
            set
            {
                this.dSsevBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public decimal CDDSsev
        {
            get
            {
                return this.cDDSsevField;
            }
            set
            {
                this.cDDSsevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDSsevSpecified
        {
            get
            {
                return this.cDDSsevFieldSpecified;
            }
            set
            {
                this.cDDSsevFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public decimal ALaitKg
        {
            get
            {
                return this.aLaitKgField;
            }
            set
            {
                this.aLaitKgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ALaitKgSpecified
        {
            get
            {
                return this.aLaitKgFieldSpecified;
            }
            set
            {
                this.aLaitKgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int ALaitBase100
        {
            get
            {
                return this.aLaitBase100Field;
            }
            set
            {
                this.aLaitBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ALaitBase100Specified
        {
            get
            {
                return this.aLaitBase100FieldSpecified;
            }
            set
            {
                this.aLaitBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public decimal CDALait
        {
            get
            {
                return this.cDALaitField;
            }
            set
            {
                this.cDALaitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDALaitSpecified
        {
            get
            {
                return this.cDALaitFieldSpecified;
            }
            set
            {
                this.cDALaitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public decimal MERPsevKg
        {
            get
            {
                return this.mERPsevKgField;
            }
            set
            {
                this.mERPsevKgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MERPsevKgSpecified
        {
            get
            {
                return this.mERPsevKgFieldSpecified;
            }
            set
            {
                this.mERPsevKgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int MERPsevBase100
        {
            get
            {
                return this.mERPsevBase100Field;
            }
            set
            {
                this.mERPsevBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MERPsevBase100Specified
        {
            get
            {
                return this.mERPsevBase100FieldSpecified;
            }
            set
            {
                this.mERPsevBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public decimal CDMERPsev
        {
            get
            {
                return this.cDMERPsevField;
            }
            set
            {
                this.cDMERPsevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDMERPsevSpecified
        {
            get
            {
                return this.cDMERPsevFieldSpecified;
            }
            set
            {
                this.cDMERPsevFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public int ISEVR
        {
            get
            {
                return this.iSEVRField;
            }
            set
            {
                this.iSEVRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ISEVRSpecified
        {
            get
            {
                return this.iSEVRFieldSpecified;
            }
            set
            {
                this.iSEVRFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public decimal CDISEVR
        {
            get
            {
                return this.cDISEVRField;
            }
            set
            {
                this.cDISEVRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDISEVRSpecified
        {
            get
            {
                return this.cDISEVRFieldSpecified;
            }
            set
            {
                this.cDISEVRFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public int IVMAT
        {
            get
            {
                return this.iVMATField;
            }
            set
            {
                this.iVMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IVMATSpecified
        {
            get
            {
                return this.iVMATFieldSpecified;
            }
            set
            {
                this.iVMATFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public decimal CDIVMAT
        {
            get
            {
                return this.cDIVMATField;
            }
            set
            {
                this.cDIVMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIVMATSpecified
        {
            get
            {
                return this.cDIVMATFieldSpecified;
            }
            set
            {
                this.cDIVMATFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public int AVEL
        {
            get
            {
                return this.aVELField;
            }
            set
            {
                this.aVELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AVELSpecified
        {
            get
            {
                return this.aVELFieldSpecified;
            }
            set
            {
                this.aVELFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public decimal CDAVEL
        {
            get
            {
                return this.cDAVELField;
            }
            set
            {
                this.cDAVELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDAVELSpecified
        {
            get
            {
                return this.cDAVELFieldSpecified;
            }
            set
            {
                this.cDAVELFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public int FOSsevBase100
        {
            get
            {
                return this.fOSsevBase100Field;
            }
            set
            {
                this.fOSsevBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FOSsevBase100Specified
        {
            get
            {
                return this.fOSsevBase100FieldSpecified;
            }
            set
            {
                this.fOSsevBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public decimal CDFOSsev
        {
            get
            {
                return this.cDFOSsevField;
            }
            set
            {
                this.cDFOSsevField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDFOSsevSpecified
        {
            get
            {
                return this.cDFOSsevFieldSpecified;
            }
            set
            {
                this.cDFOSsevFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public TypeCodeIndexAscendance IndicateurIndexAscendance
        {
            get
            {
                return this.indicateurIndexAscendanceField;
            }
            set
            {
                this.indicateurIndexAscendanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndicateurIndexAscendanceSpecified
        {
            get
            {
                return this.indicateurIndexAscendanceFieldSpecified;
            }
            set
            {
                this.indicateurIndexAscendanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public int NombreCampagnesUtilisation
        {
            get
            {
                return this.nombreCampagnesUtilisationField;
            }
            set
            {
                this.nombreCampagnesUtilisationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreCampagnesUtilisationSpecified
        {
            get
            {
                return this.nombreCampagnesUtilisationFieldSpecified;
            }
            set
            {
                this.nombreCampagnesUtilisationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public int NombreProduitsUtilises
        {
            get
            {
                return this.nombreProduitsUtilisesField;
            }
            set
            {
                this.nombreProduitsUtilisesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreProduitsUtilisesSpecified
        {
            get
            {
                return this.nombreProduitsUtilisesFieldSpecified;
            }
            set
            {
                this.nombreProduitsUtilisesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public int NombreProduitsConnectesUtilises
        {
            get
            {
                return this.nombreProduitsConnectesUtilisesField;
            }
            set
            {
                this.nombreProduitsConnectesUtilisesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreProduitsConnectesUtilisesSpecified
        {
            get
            {
                return this.nombreProduitsConnectesUtilisesFieldSpecified;
            }
            set
            {
                this.nombreProduitsConnectesUtilisesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public int NombreTroupeaux
        {
            get
            {
                return this.nombreTroupeauxField;
            }
            set
            {
                this.nombreTroupeauxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreTroupeauxSpecified
        {
            get
            {
                return this.nombreTroupeauxFieldSpecified;
            }
            set
            {
                this.nombreTroupeauxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public int NombreTroupeauxCampagnes
        {
            get
            {
                return this.nombreTroupeauxCampagnesField;
            }
            set
            {
                this.nombreTroupeauxCampagnesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreTroupeauxCampagnesSpecified
        {
            get
            {
                return this.nombreTroupeauxCampagnesFieldSpecified;
            }
            set
            {
                this.nombreTroupeauxCampagnesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public int NombreTroupeauxCampagnesConnectes
        {
            get
            {
                return this.nombreTroupeauxCampagnesConnectesField;
            }
            set
            {
                this.nombreTroupeauxCampagnesConnectesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreTroupeauxCampagnesConnectesSpecified
        {
            get
            {
                return this.nombreTroupeauxCampagnesConnectesFieldSpecified;
            }
            set
            {
                this.nombreTroupeauxCampagnesConnectesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=33)]
        public int NombreFillesAvecProduit
        {
            get
            {
                return this.nombreFillesAvecProduitField;
            }
            set
            {
                this.nombreFillesAvecProduitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreFillesAvecProduitSpecified
        {
            get
            {
                return this.nombreFillesAvecProduitFieldSpecified;
            }
            set
            {
                this.nombreFillesAvecProduitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=34)]
        public int NombrePetitsProduits
        {
            get
            {
                return this.nombrePetitsProduitsField;
            }
            set
            {
                this.nombrePetitsProduitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombrePetitsProduitsSpecified
        {
            get
            {
                return this.nombrePetitsProduitsFieldSpecified;
            }
            set
            {
                this.nombrePetitsProduitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=35)]
        public int NombrePetitsProduitsConnectes
        {
            get
            {
                return this.nombrePetitsProduitsConnectesField;
            }
            set
            {
                this.nombrePetitsProduitsConnectesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombrePetitsProduitsConnectesSpecified
        {
            get
            {
                return this.nombrePetitsProduitsConnectesFieldSpecified;
            }
            set
            {
                this.nombrePetitsProduitsConnectesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeTypeBaseIndexation:1")]
    public enum TypeCodeTypeBaseIndexation
    {
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        T,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeIndexAscendance:1")]
    public enum TypeCodeIndexAscendance
    {
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IBOVALCroissancePostSevrage
    {
        
        private TypeCodeTypeBaseIndexation typeBaseIndexationField;
        
        private bool typeBaseIndexationFieldSpecified;
        
        private decimal cRpsfKgField;
        
        private bool cRpsfKgFieldSpecified;
        
        private int cRpsfBase100Field;
        
        private bool cRpsfBase100FieldSpecified;
        
        private decimal cDCRpsfField;
        
        private bool cDCRpsfFieldSpecified;
        
        private int nombreCroissancesUtiliseesField;
        
        private bool nombreCroissancesUtiliseesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeTypeBaseIndexation TypeBaseIndexation
        {
            get
            {
                return this.typeBaseIndexationField;
            }
            set
            {
                this.typeBaseIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeBaseIndexationSpecified
        {
            get
            {
                return this.typeBaseIndexationFieldSpecified;
            }
            set
            {
                this.typeBaseIndexationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal CRpsfKg
        {
            get
            {
                return this.cRpsfKgField;
            }
            set
            {
                this.cRpsfKgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRpsfKgSpecified
        {
            get
            {
                return this.cRpsfKgFieldSpecified;
            }
            set
            {
                this.cRpsfKgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int CRpsfBase100
        {
            get
            {
                return this.cRpsfBase100Field;
            }
            set
            {
                this.cRpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRpsfBase100Specified
        {
            get
            {
                return this.cRpsfBase100FieldSpecified;
            }
            set
            {
                this.cRpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal CDCRpsf
        {
            get
            {
                return this.cDCRpsfField;
            }
            set
            {
                this.cDCRpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRpsfSpecified
        {
            get
            {
                return this.cDCRpsfFieldSpecified;
            }
            set
            {
                this.cDCRpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int NombreCroissancesUtilisees
        {
            get
            {
                return this.nombreCroissancesUtiliseesField;
            }
            set
            {
                this.nombreCroissancesUtiliseesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NombreCroissancesUtiliseesSpecified
        {
            get
            {
                return this.nombreCroissancesUtiliseesFieldSpecified;
            }
            set
            {
                this.nombreCroissancesUtiliseesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IBOVALMorphologiePostSevrage
    {
        
        private TypeCodeTypeBaseIndexation typeBaseIndexationField;
        
        private bool typeBaseIndexationFieldSpecified;
        
        private decimal dMpsfEnPointsField;
        
        private bool dMpsfEnPointsFieldSpecified;
        
        private int dMpsfBase100Field;
        
        private bool dMpsfBase100FieldSpecified;
        
        private decimal cDDMpsfField;
        
        private bool cDDMpsfFieldSpecified;
        
        private decimal dSpsfEnPointsField;
        
        private bool dSpsfEnPointsFieldSpecified;
        
        private int dSpsfBase100Field;
        
        private bool dSpsfBase100FieldSpecified;
        
        private decimal cDDSpsfField;
        
        private bool cDDSpsfFieldSpecified;
        
        private int fOSpsfBase100Field;
        
        private bool fOSpsfBase100FieldSpecified;
        
        private decimal cDFOSpsfField;
        
        private bool cDFOSpsfFieldSpecified;
        
        private decimal aFpsfEnPointsField;
        
        private bool aFpsfEnPointsFieldSpecified;
        
        private int aFpsfBase100Field;
        
        private bool aFpsfBase100FieldSpecified;
        
        private decimal cDAFpsfField;
        
        private bool cDAFpsfFieldSpecified;
        
        private decimal qRpsfEnPointsField;
        
        private bool qRpsfEnPointsFieldSpecified;
        
        private int qRpsfBase100Field;
        
        private bool qRpsfBase100FieldSpecified;
        
        private decimal cDQRpsfField;
        
        private bool cDQRpsfFieldSpecified;
        
        private decimal bASpsfEnPointsField;
        
        private bool bASpsfEnPointsFieldSpecified;
        
        private int bASpsfBase100Field;
        
        private bool bASpsfBase100FieldSpecified;
        
        private decimal cDBASpsfField;
        
        private bool cDBASpsfFieldSpecified;
        
        private decimal nGpsfEnPointsField;
        
        private bool nGpsfEnPointsFieldSpecified;
        
        private int nGpsfBase100Field;
        
        private bool nGpsfBase100FieldSpecified;
        
        private decimal cDNGpsfField;
        
        private bool cDNGpsfFieldSpecified;
        
        private decimal cSpsfEnPointsField;
        
        private bool cSpsfEnPointsFieldSpecified;
        
        private int cSpsfBase100Field;
        
        private bool cSpsfBase100FieldSpecified;
        
        private decimal cDCSpsfField;
        
        private bool cDCSpsfFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeTypeBaseIndexation TypeBaseIndexation
        {
            get
            {
                return this.typeBaseIndexationField;
            }
            set
            {
                this.typeBaseIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeBaseIndexationSpecified
        {
            get
            {
                return this.typeBaseIndexationFieldSpecified;
            }
            set
            {
                this.typeBaseIndexationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal DMpsfEnPoints
        {
            get
            {
                return this.dMpsfEnPointsField;
            }
            set
            {
                this.dMpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMpsfEnPointsSpecified
        {
            get
            {
                return this.dMpsfEnPointsFieldSpecified;
            }
            set
            {
                this.dMpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int DMpsfBase100
        {
            get
            {
                return this.dMpsfBase100Field;
            }
            set
            {
                this.dMpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMpsfBase100Specified
        {
            get
            {
                return this.dMpsfBase100FieldSpecified;
            }
            set
            {
                this.dMpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal CDDMpsf
        {
            get
            {
                return this.cDDMpsfField;
            }
            set
            {
                this.cDDMpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDMpsfSpecified
        {
            get
            {
                return this.cDDMpsfFieldSpecified;
            }
            set
            {
                this.cDDMpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal DSpsfEnPoints
        {
            get
            {
                return this.dSpsfEnPointsField;
            }
            set
            {
                this.dSpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSpsfEnPointsSpecified
        {
            get
            {
                return this.dSpsfEnPointsFieldSpecified;
            }
            set
            {
                this.dSpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int DSpsfBase100
        {
            get
            {
                return this.dSpsfBase100Field;
            }
            set
            {
                this.dSpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSpsfBase100Specified
        {
            get
            {
                return this.dSpsfBase100FieldSpecified;
            }
            set
            {
                this.dSpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDDSpsf
        {
            get
            {
                return this.cDDSpsfField;
            }
            set
            {
                this.cDDSpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDSpsfSpecified
        {
            get
            {
                return this.cDDSpsfFieldSpecified;
            }
            set
            {
                this.cDDSpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int FOSpsfBase100
        {
            get
            {
                return this.fOSpsfBase100Field;
            }
            set
            {
                this.fOSpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FOSpsfBase100Specified
        {
            get
            {
                return this.fOSpsfBase100FieldSpecified;
            }
            set
            {
                this.fOSpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal CDFOSpsf
        {
            get
            {
                return this.cDFOSpsfField;
            }
            set
            {
                this.cDFOSpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDFOSpsfSpecified
        {
            get
            {
                return this.cDFOSpsfFieldSpecified;
            }
            set
            {
                this.cDFOSpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public decimal AFpsfEnPoints
        {
            get
            {
                return this.aFpsfEnPointsField;
            }
            set
            {
                this.aFpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AFpsfEnPointsSpecified
        {
            get
            {
                return this.aFpsfEnPointsFieldSpecified;
            }
            set
            {
                this.aFpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int AFpsfBase100
        {
            get
            {
                return this.aFpsfBase100Field;
            }
            set
            {
                this.aFpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AFpsfBase100Specified
        {
            get
            {
                return this.aFpsfBase100FieldSpecified;
            }
            set
            {
                this.aFpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public decimal CDAFpsf
        {
            get
            {
                return this.cDAFpsfField;
            }
            set
            {
                this.cDAFpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDAFpsfSpecified
        {
            get
            {
                return this.cDAFpsfFieldSpecified;
            }
            set
            {
                this.cDAFpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public decimal QRpsfEnPoints
        {
            get
            {
                return this.qRpsfEnPointsField;
            }
            set
            {
                this.qRpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QRpsfEnPointsSpecified
        {
            get
            {
                return this.qRpsfEnPointsFieldSpecified;
            }
            set
            {
                this.qRpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int QRpsfBase100
        {
            get
            {
                return this.qRpsfBase100Field;
            }
            set
            {
                this.qRpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QRpsfBase100Specified
        {
            get
            {
                return this.qRpsfBase100FieldSpecified;
            }
            set
            {
                this.qRpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public decimal CDQRpsf
        {
            get
            {
                return this.cDQRpsfField;
            }
            set
            {
                this.cDQRpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDQRpsfSpecified
        {
            get
            {
                return this.cDQRpsfFieldSpecified;
            }
            set
            {
                this.cDQRpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public decimal BASpsfEnPoints
        {
            get
            {
                return this.bASpsfEnPointsField;
            }
            set
            {
                this.bASpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BASpsfEnPointsSpecified
        {
            get
            {
                return this.bASpsfEnPointsFieldSpecified;
            }
            set
            {
                this.bASpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int BASpsfBase100
        {
            get
            {
                return this.bASpsfBase100Field;
            }
            set
            {
                this.bASpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BASpsfBase100Specified
        {
            get
            {
                return this.bASpsfBase100FieldSpecified;
            }
            set
            {
                this.bASpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public decimal CDBASpsf
        {
            get
            {
                return this.cDBASpsfField;
            }
            set
            {
                this.cDBASpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDBASpsfSpecified
        {
            get
            {
                return this.cDBASpsfFieldSpecified;
            }
            set
            {
                this.cDBASpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public decimal NGpsfEnPoints
        {
            get
            {
                return this.nGpsfEnPointsField;
            }
            set
            {
                this.nGpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NGpsfEnPointsSpecified
        {
            get
            {
                return this.nGpsfEnPointsFieldSpecified;
            }
            set
            {
                this.nGpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int NGpsfBase100
        {
            get
            {
                return this.nGpsfBase100Field;
            }
            set
            {
                this.nGpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NGpsfBase100Specified
        {
            get
            {
                return this.nGpsfBase100FieldSpecified;
            }
            set
            {
                this.nGpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public decimal CDNGpsf
        {
            get
            {
                return this.cDNGpsfField;
            }
            set
            {
                this.cDNGpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDNGpsfSpecified
        {
            get
            {
                return this.cDNGpsfFieldSpecified;
            }
            set
            {
                this.cDNGpsfFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public decimal CSpsfEnPoints
        {
            get
            {
                return this.cSpsfEnPointsField;
            }
            set
            {
                this.cSpsfEnPointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CSpsfEnPointsSpecified
        {
            get
            {
                return this.cSpsfEnPointsFieldSpecified;
            }
            set
            {
                this.cSpsfEnPointsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public int CSpsfBase100
        {
            get
            {
                return this.cSpsfBase100Field;
            }
            set
            {
                this.cSpsfBase100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CSpsfBase100Specified
        {
            get
            {
                return this.cSpsfBase100FieldSpecified;
            }
            set
            {
                this.cSpsfBase100FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public decimal CDCSpsf
        {
            get
            {
                return this.cDCSpsfField;
            }
            set
            {
                this.cDCSpsfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCSpsfSpecified
        {
            get
            {
                return this.cDCSpsfFieldSpecified;
            }
            set
            {
                this.cDCSpsfFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IBOVALVieProductive
    {
        
        private TypeCodeTypeBaseIndexation typeBaseIndexationField;
        
        private bool typeBaseIndexationFieldSpecified;
        
        private int rIAPBase100EnFermeField;
        
        private bool rIAPBase100EnFermeFieldSpecified;
        
        private decimal cDRIAPField;
        
        private bool cDRIAPFieldSpecified;
        
        private int pNUMBase100EffReproEnFermeField;
        
        private bool pNUMBase100EffReproEnFermeFieldSpecified;
        
        private decimal cDPNUMField;
        
        private bool cDPNUMFieldSpecified;
        
        private int lONGEVBase100EnFermeField;
        
        private bool lONGEVBase100EnFermeFieldSpecified;
        
        private decimal cDLONGEVField;
        
        private bool cDLONGEVFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodeTypeBaseIndexation TypeBaseIndexation
        {
            get
            {
                return this.typeBaseIndexationField;
            }
            set
            {
                this.typeBaseIndexationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeBaseIndexationSpecified
        {
            get
            {
                return this.typeBaseIndexationFieldSpecified;
            }
            set
            {
                this.typeBaseIndexationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int RIAPBase100EnFerme
        {
            get
            {
                return this.rIAPBase100EnFermeField;
            }
            set
            {
                this.rIAPBase100EnFermeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RIAPBase100EnFermeSpecified
        {
            get
            {
                return this.rIAPBase100EnFermeFieldSpecified;
            }
            set
            {
                this.rIAPBase100EnFermeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDRIAP
        {
            get
            {
                return this.cDRIAPField;
            }
            set
            {
                this.cDRIAPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDRIAPSpecified
        {
            get
            {
                return this.cDRIAPFieldSpecified;
            }
            set
            {
                this.cDRIAPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int PNUMBase100EffReproEnFerme
        {
            get
            {
                return this.pNUMBase100EffReproEnFermeField;
            }
            set
            {
                this.pNUMBase100EffReproEnFermeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PNUMBase100EffReproEnFermeSpecified
        {
            get
            {
                return this.pNUMBase100EffReproEnFermeFieldSpecified;
            }
            set
            {
                this.pNUMBase100EffReproEnFermeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal CDPNUM
        {
            get
            {
                return this.cDPNUMField;
            }
            set
            {
                this.cDPNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPNUMSpecified
        {
            get
            {
                return this.cDPNUMFieldSpecified;
            }
            set
            {
                this.cDPNUMFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int LONGEVBase100EnFerme
        {
            get
            {
                return this.lONGEVBase100EnFermeField;
            }
            set
            {
                this.lONGEVBase100EnFermeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LONGEVBase100EnFermeSpecified
        {
            get
            {
                return this.lONGEVBase100EnFermeFieldSpecified;
            }
            set
            {
                this.lONGEVBase100EnFermeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDLONGEV
        {
            get
            {
                return this.cDLONGEVField;
            }
            set
            {
                this.cDLONGEVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDLONGEVSpecified
        {
            get
            {
                return this.cDLONGEVFieldSpecified;
            }
            set
            {
                this.cDLONGEVFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexCDABJeunesBovins
    {
        
        private string baseReferenceField;
        
        private int cRjbsField;
        
        private bool cRjbsFieldSpecified;
        
        private decimal cDCRjbsField;
        
        private bool cDCRjbsFieldSpecified;
        
        private int vOSjbsField;
        
        private bool vOSjbsFieldSpecified;
        
        private decimal cDVOSjbsField;
        
        private bool cDVOSjbsFieldSpecified;
        
        private int dMjbsField;
        
        private bool dMjbsFieldSpecified;
        
        private decimal cDDMjbsField;
        
        private bool cDDMjbsFieldSpecified;
        
        private int dSjbsField;
        
        private bool dSjbsFieldSpecified;
        
        private decimal cDDSjbsField;
        
        private bool cDDSjbsFieldSpecified;
        
        private int aFjbsField;
        
        private bool aFjbsFieldSpecified;
        
        private decimal cDAFjbsField;
        
        private bool cDAFjbsFieldSpecified;
        
        private int qRjbsField;
        
        private bool qRjbsFieldSpecified;
        
        private decimal cDQRjbsField;
        
        private bool cDQRjbsFieldSpecified;
        
        private int iABVjbsField;
        
        private bool iABVjbsFieldSpecified;
        
        private decimal cDIABVjbsField;
        
        private bool cDIABVjbsFieldSpecified;
        
        private int pCARjbsField;
        
        private bool pCARjbsFieldSpecified;
        
        private decimal cDPCARjbsField;
        
        private bool cDPCARjbsFieldSpecified;
        
        private int rDTjbsField;
        
        private bool rDTjbsFieldSpecified;
        
        private decimal cDRTDjbsField;
        
        private bool cDRTDjbsFieldSpecified;
        
        private int cONFjbsField;
        
        private bool cONFjbsFieldSpecified;
        
        private decimal cDCONFjbsField;
        
        private bool cDCONFjbsFieldSpecified;
        
        private int cECjbsField;
        
        private bool cECjbsFieldSpecified;
        
        private decimal cDCECjbsField;
        
        private bool cDCECjbsFieldSpecified;
        
        private int cDCjbsField;
        
        private bool cDCjbsFieldSpecified;
        
        private decimal cDCDCjbsField;
        
        private bool cDCDCjbsFieldSpecified;
        
        private int cACjbsField;
        
        private bool cACjbsFieldSpecified;
        
        private decimal cDCACjbsField;
        
        private bool cDCACjbsFieldSpecified;
        
        private int cCUjbsField;
        
        private bool cCUjbsFieldSpecified;
        
        private decimal cDCCUjbsField;
        
        private bool cDCCUjbsFieldSpecified;
        
        private int cCAjbsField;
        
        private bool cCAjbsFieldSpecified;
        
        private decimal cDCCAjbsField;
        
        private bool cDCCAjbsFieldSpecified;
        
        private int gRASjbsField;
        
        private bool gRASjbsFieldSpecified;
        
        private decimal cDGRASjbsField;
        
        private bool cDGRASjbsFieldSpecified;
        
        private int iABjbsField;
        
        private bool iABjbsFieldSpecified;
        
        private decimal cDIABjbsField;
        
        private bool cDIABjbsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string BaseReference
        {
            get
            {
                return this.baseReferenceField;
            }
            set
            {
                this.baseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CRjbs
        {
            get
            {
                return this.cRjbsField;
            }
            set
            {
                this.cRjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRjbsSpecified
        {
            get
            {
                return this.cRjbsFieldSpecified;
            }
            set
            {
                this.cRjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDCRjbs
        {
            get
            {
                return this.cDCRjbsField;
            }
            set
            {
                this.cDCRjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRjbsSpecified
        {
            get
            {
                return this.cDCRjbsFieldSpecified;
            }
            set
            {
                this.cDCRjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int VOSjbs
        {
            get
            {
                return this.vOSjbsField;
            }
            set
            {
                this.vOSjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VOSjbsSpecified
        {
            get
            {
                return this.vOSjbsFieldSpecified;
            }
            set
            {
                this.vOSjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal CDVOSjbs
        {
            get
            {
                return this.cDVOSjbsField;
            }
            set
            {
                this.cDVOSjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDVOSjbsSpecified
        {
            get
            {
                return this.cDVOSjbsFieldSpecified;
            }
            set
            {
                this.cDVOSjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int DMjbs
        {
            get
            {
                return this.dMjbsField;
            }
            set
            {
                this.dMjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMjbsSpecified
        {
            get
            {
                return this.dMjbsFieldSpecified;
            }
            set
            {
                this.dMjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDDMjbs
        {
            get
            {
                return this.cDDMjbsField;
            }
            set
            {
                this.cDDMjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDMjbsSpecified
        {
            get
            {
                return this.cDDMjbsFieldSpecified;
            }
            set
            {
                this.cDDMjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int DSjbs
        {
            get
            {
                return this.dSjbsField;
            }
            set
            {
                this.dSjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSjbsSpecified
        {
            get
            {
                return this.dSjbsFieldSpecified;
            }
            set
            {
                this.dSjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal CDDSjbs
        {
            get
            {
                return this.cDDSjbsField;
            }
            set
            {
                this.cDDSjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDSjbsSpecified
        {
            get
            {
                return this.cDDSjbsFieldSpecified;
            }
            set
            {
                this.cDDSjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int AFjbs
        {
            get
            {
                return this.aFjbsField;
            }
            set
            {
                this.aFjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AFjbsSpecified
        {
            get
            {
                return this.aFjbsFieldSpecified;
            }
            set
            {
                this.aFjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public decimal CDAFjbs
        {
            get
            {
                return this.cDAFjbsField;
            }
            set
            {
                this.cDAFjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDAFjbsSpecified
        {
            get
            {
                return this.cDAFjbsFieldSpecified;
            }
            set
            {
                this.cDAFjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int QRjbs
        {
            get
            {
                return this.qRjbsField;
            }
            set
            {
                this.qRjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QRjbsSpecified
        {
            get
            {
                return this.qRjbsFieldSpecified;
            }
            set
            {
                this.qRjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public decimal CDQRjbs
        {
            get
            {
                return this.cDQRjbsField;
            }
            set
            {
                this.cDQRjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDQRjbsSpecified
        {
            get
            {
                return this.cDQRjbsFieldSpecified;
            }
            set
            {
                this.cDQRjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int IABVjbs
        {
            get
            {
                return this.iABVjbsField;
            }
            set
            {
                this.iABVjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABVjbsSpecified
        {
            get
            {
                return this.iABVjbsFieldSpecified;
            }
            set
            {
                this.iABVjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public decimal CDIABVjbs
        {
            get
            {
                return this.cDIABVjbsField;
            }
            set
            {
                this.cDIABVjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIABVjbsSpecified
        {
            get
            {
                return this.cDIABVjbsFieldSpecified;
            }
            set
            {
                this.cDIABVjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int PCARjbs
        {
            get
            {
                return this.pCARjbsField;
            }
            set
            {
                this.pCARjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PCARjbsSpecified
        {
            get
            {
                return this.pCARjbsFieldSpecified;
            }
            set
            {
                this.pCARjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public decimal CDPCARjbs
        {
            get
            {
                return this.cDPCARjbsField;
            }
            set
            {
                this.cDPCARjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPCARjbsSpecified
        {
            get
            {
                return this.cDPCARjbsFieldSpecified;
            }
            set
            {
                this.cDPCARjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int RDTjbs
        {
            get
            {
                return this.rDTjbsField;
            }
            set
            {
                this.rDTjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RDTjbsSpecified
        {
            get
            {
                return this.rDTjbsFieldSpecified;
            }
            set
            {
                this.rDTjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public decimal CDRTDjbs
        {
            get
            {
                return this.cDRTDjbsField;
            }
            set
            {
                this.cDRTDjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDRTDjbsSpecified
        {
            get
            {
                return this.cDRTDjbsFieldSpecified;
            }
            set
            {
                this.cDRTDjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int CONFjbs
        {
            get
            {
                return this.cONFjbsField;
            }
            set
            {
                this.cONFjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CONFjbsSpecified
        {
            get
            {
                return this.cONFjbsFieldSpecified;
            }
            set
            {
                this.cONFjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public decimal CDCONFjbs
        {
            get
            {
                return this.cDCONFjbsField;
            }
            set
            {
                this.cDCONFjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCONFjbsSpecified
        {
            get
            {
                return this.cDCONFjbsFieldSpecified;
            }
            set
            {
                this.cDCONFjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int CECjbs
        {
            get
            {
                return this.cECjbsField;
            }
            set
            {
                this.cECjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CECjbsSpecified
        {
            get
            {
                return this.cECjbsFieldSpecified;
            }
            set
            {
                this.cECjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public decimal CDCECjbs
        {
            get
            {
                return this.cDCECjbsField;
            }
            set
            {
                this.cDCECjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCECjbsSpecified
        {
            get
            {
                return this.cDCECjbsFieldSpecified;
            }
            set
            {
                this.cDCECjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public int CDCjbs
        {
            get
            {
                return this.cDCjbsField;
            }
            set
            {
                this.cDCjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCjbsSpecified
        {
            get
            {
                return this.cDCjbsFieldSpecified;
            }
            set
            {
                this.cDCjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public decimal CDCDCjbs
        {
            get
            {
                return this.cDCDCjbsField;
            }
            set
            {
                this.cDCDCjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCDCjbsSpecified
        {
            get
            {
                return this.cDCDCjbsFieldSpecified;
            }
            set
            {
                this.cDCDCjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public int CACjbs
        {
            get
            {
                return this.cACjbsField;
            }
            set
            {
                this.cACjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CACjbsSpecified
        {
            get
            {
                return this.cACjbsFieldSpecified;
            }
            set
            {
                this.cACjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public decimal CDCACjbs
        {
            get
            {
                return this.cDCACjbsField;
            }
            set
            {
                this.cDCACjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCACjbsSpecified
        {
            get
            {
                return this.cDCACjbsFieldSpecified;
            }
            set
            {
                this.cDCACjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public int CCUjbs
        {
            get
            {
                return this.cCUjbsField;
            }
            set
            {
                this.cCUjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CCUjbsSpecified
        {
            get
            {
                return this.cCUjbsFieldSpecified;
            }
            set
            {
                this.cCUjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public decimal CDCCUjbs
        {
            get
            {
                return this.cDCCUjbsField;
            }
            set
            {
                this.cDCCUjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCCUjbsSpecified
        {
            get
            {
                return this.cDCCUjbsFieldSpecified;
            }
            set
            {
                this.cDCCUjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public int CCAjbs
        {
            get
            {
                return this.cCAjbsField;
            }
            set
            {
                this.cCAjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CCAjbsSpecified
        {
            get
            {
                return this.cCAjbsFieldSpecified;
            }
            set
            {
                this.cCAjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public decimal CDCCAjbs
        {
            get
            {
                return this.cDCCAjbsField;
            }
            set
            {
                this.cDCCAjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCCAjbsSpecified
        {
            get
            {
                return this.cDCCAjbsFieldSpecified;
            }
            set
            {
                this.cDCCAjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public int GRASjbs
        {
            get
            {
                return this.gRASjbsField;
            }
            set
            {
                this.gRASjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GRASjbsSpecified
        {
            get
            {
                return this.gRASjbsFieldSpecified;
            }
            set
            {
                this.gRASjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public decimal CDGRASjbs
        {
            get
            {
                return this.cDGRASjbsField;
            }
            set
            {
                this.cDGRASjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDGRASjbsSpecified
        {
            get
            {
                return this.cDGRASjbsFieldSpecified;
            }
            set
            {
                this.cDGRASjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=33)]
        public int IABjbs
        {
            get
            {
                return this.iABjbsField;
            }
            set
            {
                this.iABjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABjbsSpecified
        {
            get
            {
                return this.iABjbsFieldSpecified;
            }
            set
            {
                this.iABjbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=34)]
        public decimal CDIABjbs
        {
            get
            {
                return this.cDIABjbsField;
            }
            set
            {
                this.cDIABjbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIABjbsSpecified
        {
            get
            {
                return this.cDIABjbsFieldSpecified;
            }
            set
            {
                this.cDIABjbsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexCDFaciliteNaissance
    {
        
        private string baseReferenceField;
        
        private int fNtestField;
        
        private decimal cDFNtestField;
        
        private bool cDFNtestFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string BaseReference
        {
            get
            {
                return this.baseReferenceField;
            }
            set
            {
                this.baseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int FNtest
        {
            get
            {
                return this.fNtestField;
            }
            set
            {
                this.fNtestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDFNtest
        {
            get
            {
                return this.cDFNtestField;
            }
            set
            {
                this.cDFNtestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDFNtestSpecified
        {
            get
            {
                return this.cDFNtestFieldSpecified;
            }
            set
            {
                this.cDFNtestFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexCDMuscularitePrecoce
    {
        
        private string baseReferenceField;
        
        private int mPv3sField;
        
        private bool mPv3sFieldSpecified;
        
        private decimal cDMPv3sField;
        
        private bool cDMPv3sFieldSpecified;
        
        private int tVv3sField;
        
        private bool tVv3sFieldSpecified;
        
        private decimal cDTVv3sField;
        
        private bool cDTVv3sFieldSpecified;
        
        private int fOSv3sField;
        
        private bool fOSv3sFieldSpecified;
        
        private decimal cDFOSv3sField;
        
        private bool cDFOSv3sFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string BaseReference
        {
            get
            {
                return this.baseReferenceField;
            }
            set
            {
                this.baseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int MPv3s
        {
            get
            {
                return this.mPv3sField;
            }
            set
            {
                this.mPv3sField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MPv3sSpecified
        {
            get
            {
                return this.mPv3sFieldSpecified;
            }
            set
            {
                this.mPv3sFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDMPv3s
        {
            get
            {
                return this.cDMPv3sField;
            }
            set
            {
                this.cDMPv3sField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDMPv3sSpecified
        {
            get
            {
                return this.cDMPv3sFieldSpecified;
            }
            set
            {
                this.cDMPv3sFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int TVv3s
        {
            get
            {
                return this.tVv3sField;
            }
            set
            {
                this.tVv3sField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TVv3sSpecified
        {
            get
            {
                return this.tVv3sFieldSpecified;
            }
            set
            {
                this.tVv3sFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal CDTVv3s
        {
            get
            {
                return this.cDTVv3sField;
            }
            set
            {
                this.cDTVv3sField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDTVv3sSpecified
        {
            get
            {
                return this.cDTVv3sFieldSpecified;
            }
            set
            {
                this.cDTVv3sFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int FOSv3s
        {
            get
            {
                return this.fOSv3sField;
            }
            set
            {
                this.fOSv3sField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FOSv3sSpecified
        {
            get
            {
                return this.fOSv3sFieldSpecified;
            }
            set
            {
                this.fOSv3sFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDFOSv3s
        {
            get
            {
                return this.cDFOSv3sField;
            }
            set
            {
                this.cDFOSv3sField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDFOSv3sSpecified
        {
            get
            {
                return this.cDFOSv3sFieldSpecified;
            }
            set
            {
                this.cDFOSv3sFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexCDQualitesMaternelles
    {
        
        private string baseReferenceField;
        
        private int cRqmsField;
        
        private bool cRqmsFieldSpecified;
        
        private decimal cDCRqmsField;
        
        private bool cDCRqmsFieldSpecified;
        
        private int dMqmsField;
        
        private bool dMqmsFieldSpecified;
        
        private decimal cDDMqmsField;
        
        private bool cDDMqmsFieldSpecified;
        
        private int dSqmsField;
        
        private bool dSqmsFieldSpecified;
        
        private decimal cDDSqmsField;
        
        private bool cDDSqmsFieldSpecified;
        
        private int aFqmsField;
        
        private bool aFqmsFieldSpecified;
        
        private decimal cDAFqmsField;
        
        private bool cDAFqmsFieldSpecified;
        
        private int qRqmsField;
        
        private bool qRqmsFieldSpecified;
        
        private decimal cDQRqmsField;
        
        private bool cDQRqmsFieldSpecified;
        
        private int hGqmsField;
        
        private bool hGqmsFieldSpecified;
        
        private decimal cDHGqmsField;
        
        private bool cDHGqmsFieldSpecified;
        
        private int pRECqmsField;
        
        private bool pRECqmsFieldSpecified;
        
        private decimal cDPRECqmsField;
        
        private bool cDPRECqmsFieldSpecified;
        
        private int rIAqmsField;
        
        private bool rIAqmsFieldSpecified;
        
        private decimal cDRIAqmsField;
        
        private bool cDRIAqmsFieldSpecified;
        
        private int vIEqmsField;
        
        private bool vIEqmsFieldSpecified;
        
        private decimal cDVIEqmsField;
        
        private bool cDVIEqmsFieldSpecified;
        
        private int tXTDIFqmsField;
        
        private bool tXTDIFqmsFieldSpecified;
        
        private decimal cDTXTDIFqmsField;
        
        private bool cDTXTDIFqmsFieldSpecified;
        
        private int mERPNqmsField;
        
        private bool mERPNqmsFieldSpecified;
        
        private decimal cDMERPNqmsField;
        
        private bool cDMERPNqmsFieldSpecified;
        
        private int pREPqmsField;
        
        private bool pREPqmsFieldSpecified;
        
        private decimal cDPREPqmsField;
        
        private bool cDPREPqmsFieldSpecified;
        
        private int pVELqmsField;
        
        private bool pVELqmsFieldSpecified;
        
        private decimal cDPVELqmsField;
        
        private bool cDPVELqmsFieldSpecified;
        
        private int oPqmsField;
        
        private bool oPqmsFieldSpecified;
        
        private decimal cDOPqmsField;
        
        private bool cDOPqmsFieldSpecified;
        
        private int pLAITqmsField;
        
        private bool pLAITqmsFieldSpecified;
        
        private decimal cDPLAITqmsField;
        
        private bool cDPLAITqmsFieldSpecified;
        
        private int mERP4qmsField;
        
        private bool mERP4qmsFieldSpecified;
        
        private decimal cDMERP4qmsField;
        
        private bool cDMERP4qmsFieldSpecified;
        
        private int mERP6qmsField;
        
        private bool mERP6qmsFieldSpecified;
        
        private decimal cDMERP6qmsField;
        
        private bool cDMERP6qmsFieldSpecified;
        
        private int mERDMqmsField;
        
        private bool mERDMqmsFieldSpecified;
        
        private decimal cDMERDMqmsField;
        
        private bool cDMERDMqmsFieldSpecified;
        
        private int iMOCRqmsField;
        
        private bool iMOCRqmsFieldSpecified;
        
        private decimal cDIMOCRqmsField;
        
        private bool cDIMOCRqmsFieldSpecified;
        
        private int iFERqmsField;
        
        private bool iFERqmsFieldSpecified;
        
        private decimal cDIFERqmsField;
        
        private bool cDIFERqmsFieldSpecified;
        
        private int iVELqmsField;
        
        private bool iVELqmsFieldSpecified;
        
        private decimal cDIVELqmsField;
        
        private bool cDIVELqmsFieldSpecified;
        
        private int iMERqmsField;
        
        private bool iMERqmsFieldSpecified;
        
        private decimal cDIMERqmsField;
        
        private bool cDIMERqmsFieldSpecified;
        
        private int iQMqmsField;
        
        private bool iQMqmsFieldSpecified;
        
        private decimal cDIQMqmsField;
        
        private bool cDIQMqmsFieldSpecified;
        
        private string dEEqmsField;
        
        private string lADqmsField;
        
        private string aRCqmsField;
        
        private string lACqmsField;
        
        private string ePDqmsField;
        
        private string gRCqmsField;
        
        private string lODqmsField;
        
        private string lOBqmsField;
        
        private string lAHqmsField;
        
        private string dEVqmsField;
        
        private string tETqmsField;
        
        private string aAVqmsField;
        
        private string aARqmsField;
        
        private string rEDqmsField;
        
        private string eTAqmsField;
        
        private string lOCqmsField;
        
        private string lATqmsField;
        
        private string lAPqmsField;
        
        private string pPOqmsField;
        
        private string hARqmsField;
        
        private string pOIqmsField;
        
        private string lAIqmsField;
        
        private string bASqmsField;
        
        private string eXTqmsField;
        
        private string cOUqmsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string BaseReference
        {
            get
            {
                return this.baseReferenceField;
            }
            set
            {
                this.baseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CRqms
        {
            get
            {
                return this.cRqmsField;
            }
            set
            {
                this.cRqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRqmsSpecified
        {
            get
            {
                return this.cRqmsFieldSpecified;
            }
            set
            {
                this.cRqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDCRqms
        {
            get
            {
                return this.cDCRqmsField;
            }
            set
            {
                this.cDCRqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRqmsSpecified
        {
            get
            {
                return this.cDCRqmsFieldSpecified;
            }
            set
            {
                this.cDCRqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int DMqms
        {
            get
            {
                return this.dMqmsField;
            }
            set
            {
                this.dMqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMqmsSpecified
        {
            get
            {
                return this.dMqmsFieldSpecified;
            }
            set
            {
                this.dMqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal CDDMqms
        {
            get
            {
                return this.cDDMqmsField;
            }
            set
            {
                this.cDDMqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDMqmsSpecified
        {
            get
            {
                return this.cDDMqmsFieldSpecified;
            }
            set
            {
                this.cDDMqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int DSqms
        {
            get
            {
                return this.dSqmsField;
            }
            set
            {
                this.dSqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSqmsSpecified
        {
            get
            {
                return this.dSqmsFieldSpecified;
            }
            set
            {
                this.dSqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDDSqms
        {
            get
            {
                return this.cDDSqmsField;
            }
            set
            {
                this.cDDSqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDSqmsSpecified
        {
            get
            {
                return this.cDDSqmsFieldSpecified;
            }
            set
            {
                this.cDDSqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int AFqms
        {
            get
            {
                return this.aFqmsField;
            }
            set
            {
                this.aFqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AFqmsSpecified
        {
            get
            {
                return this.aFqmsFieldSpecified;
            }
            set
            {
                this.aFqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal CDAFqms
        {
            get
            {
                return this.cDAFqmsField;
            }
            set
            {
                this.cDAFqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDAFqmsSpecified
        {
            get
            {
                return this.cDAFqmsFieldSpecified;
            }
            set
            {
                this.cDAFqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int QRqms
        {
            get
            {
                return this.qRqmsField;
            }
            set
            {
                this.qRqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QRqmsSpecified
        {
            get
            {
                return this.qRqmsFieldSpecified;
            }
            set
            {
                this.qRqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public decimal CDQRqms
        {
            get
            {
                return this.cDQRqmsField;
            }
            set
            {
                this.cDQRqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDQRqmsSpecified
        {
            get
            {
                return this.cDQRqmsFieldSpecified;
            }
            set
            {
                this.cDQRqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int HGqms
        {
            get
            {
                return this.hGqmsField;
            }
            set
            {
                this.hGqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HGqmsSpecified
        {
            get
            {
                return this.hGqmsFieldSpecified;
            }
            set
            {
                this.hGqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public decimal CDHGqms
        {
            get
            {
                return this.cDHGqmsField;
            }
            set
            {
                this.cDHGqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDHGqmsSpecified
        {
            get
            {
                return this.cDHGqmsFieldSpecified;
            }
            set
            {
                this.cDHGqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int PRECqms
        {
            get
            {
                return this.pRECqmsField;
            }
            set
            {
                this.pRECqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PRECqmsSpecified
        {
            get
            {
                return this.pRECqmsFieldSpecified;
            }
            set
            {
                this.pRECqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public decimal CDPRECqms
        {
            get
            {
                return this.cDPRECqmsField;
            }
            set
            {
                this.cDPRECqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPRECqmsSpecified
        {
            get
            {
                return this.cDPRECqmsFieldSpecified;
            }
            set
            {
                this.cDPRECqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int RIAqms
        {
            get
            {
                return this.rIAqmsField;
            }
            set
            {
                this.rIAqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RIAqmsSpecified
        {
            get
            {
                return this.rIAqmsFieldSpecified;
            }
            set
            {
                this.rIAqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public decimal CDRIAqms
        {
            get
            {
                return this.cDRIAqmsField;
            }
            set
            {
                this.cDRIAqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDRIAqmsSpecified
        {
            get
            {
                return this.cDRIAqmsFieldSpecified;
            }
            set
            {
                this.cDRIAqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int VIEqms
        {
            get
            {
                return this.vIEqmsField;
            }
            set
            {
                this.vIEqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VIEqmsSpecified
        {
            get
            {
                return this.vIEqmsFieldSpecified;
            }
            set
            {
                this.vIEqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public decimal CDVIEqms
        {
            get
            {
                return this.cDVIEqmsField;
            }
            set
            {
                this.cDVIEqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDVIEqmsSpecified
        {
            get
            {
                return this.cDVIEqmsFieldSpecified;
            }
            set
            {
                this.cDVIEqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int TXTDIFqms
        {
            get
            {
                return this.tXTDIFqmsField;
            }
            set
            {
                this.tXTDIFqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TXTDIFqmsSpecified
        {
            get
            {
                return this.tXTDIFqmsFieldSpecified;
            }
            set
            {
                this.tXTDIFqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public decimal CDTXTDIFqms
        {
            get
            {
                return this.cDTXTDIFqmsField;
            }
            set
            {
                this.cDTXTDIFqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDTXTDIFqmsSpecified
        {
            get
            {
                return this.cDTXTDIFqmsFieldSpecified;
            }
            set
            {
                this.cDTXTDIFqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int MERPNqms
        {
            get
            {
                return this.mERPNqmsField;
            }
            set
            {
                this.mERPNqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MERPNqmsSpecified
        {
            get
            {
                return this.mERPNqmsFieldSpecified;
            }
            set
            {
                this.mERPNqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public decimal CDMERPNqms
        {
            get
            {
                return this.cDMERPNqmsField;
            }
            set
            {
                this.cDMERPNqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDMERPNqmsSpecified
        {
            get
            {
                return this.cDMERPNqmsFieldSpecified;
            }
            set
            {
                this.cDMERPNqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public int PREPqms
        {
            get
            {
                return this.pREPqmsField;
            }
            set
            {
                this.pREPqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PREPqmsSpecified
        {
            get
            {
                return this.pREPqmsFieldSpecified;
            }
            set
            {
                this.pREPqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public decimal CDPREPqms
        {
            get
            {
                return this.cDPREPqmsField;
            }
            set
            {
                this.cDPREPqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPREPqmsSpecified
        {
            get
            {
                return this.cDPREPqmsFieldSpecified;
            }
            set
            {
                this.cDPREPqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public int PVELqms
        {
            get
            {
                return this.pVELqmsField;
            }
            set
            {
                this.pVELqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PVELqmsSpecified
        {
            get
            {
                return this.pVELqmsFieldSpecified;
            }
            set
            {
                this.pVELqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public decimal CDPVELqms
        {
            get
            {
                return this.cDPVELqmsField;
            }
            set
            {
                this.cDPVELqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPVELqmsSpecified
        {
            get
            {
                return this.cDPVELqmsFieldSpecified;
            }
            set
            {
                this.cDPVELqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public int OPqms
        {
            get
            {
                return this.oPqmsField;
            }
            set
            {
                this.oPqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OPqmsSpecified
        {
            get
            {
                return this.oPqmsFieldSpecified;
            }
            set
            {
                this.oPqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public decimal CDOPqms
        {
            get
            {
                return this.cDOPqmsField;
            }
            set
            {
                this.cDOPqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDOPqmsSpecified
        {
            get
            {
                return this.cDOPqmsFieldSpecified;
            }
            set
            {
                this.cDOPqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public int PLAITqms
        {
            get
            {
                return this.pLAITqmsField;
            }
            set
            {
                this.pLAITqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PLAITqmsSpecified
        {
            get
            {
                return this.pLAITqmsFieldSpecified;
            }
            set
            {
                this.pLAITqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public decimal CDPLAITqms
        {
            get
            {
                return this.cDPLAITqmsField;
            }
            set
            {
                this.cDPLAITqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPLAITqmsSpecified
        {
            get
            {
                return this.cDPLAITqmsFieldSpecified;
            }
            set
            {
                this.cDPLAITqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public int MERP4qms
        {
            get
            {
                return this.mERP4qmsField;
            }
            set
            {
                this.mERP4qmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MERP4qmsSpecified
        {
            get
            {
                return this.mERP4qmsFieldSpecified;
            }
            set
            {
                this.mERP4qmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public decimal CDMERP4qms
        {
            get
            {
                return this.cDMERP4qmsField;
            }
            set
            {
                this.cDMERP4qmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDMERP4qmsSpecified
        {
            get
            {
                return this.cDMERP4qmsFieldSpecified;
            }
            set
            {
                this.cDMERP4qmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=33)]
        public int MERP6qms
        {
            get
            {
                return this.mERP6qmsField;
            }
            set
            {
                this.mERP6qmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MERP6qmsSpecified
        {
            get
            {
                return this.mERP6qmsFieldSpecified;
            }
            set
            {
                this.mERP6qmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=34)]
        public decimal CDMERP6qms
        {
            get
            {
                return this.cDMERP6qmsField;
            }
            set
            {
                this.cDMERP6qmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDMERP6qmsSpecified
        {
            get
            {
                return this.cDMERP6qmsFieldSpecified;
            }
            set
            {
                this.cDMERP6qmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=35)]
        public int MERDMqms
        {
            get
            {
                return this.mERDMqmsField;
            }
            set
            {
                this.mERDMqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MERDMqmsSpecified
        {
            get
            {
                return this.mERDMqmsFieldSpecified;
            }
            set
            {
                this.mERDMqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=36)]
        public decimal CDMERDMqms
        {
            get
            {
                return this.cDMERDMqmsField;
            }
            set
            {
                this.cDMERDMqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDMERDMqmsSpecified
        {
            get
            {
                return this.cDMERDMqmsFieldSpecified;
            }
            set
            {
                this.cDMERDMqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=37)]
        public int IMOCRqms
        {
            get
            {
                return this.iMOCRqmsField;
            }
            set
            {
                this.iMOCRqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IMOCRqmsSpecified
        {
            get
            {
                return this.iMOCRqmsFieldSpecified;
            }
            set
            {
                this.iMOCRqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=38)]
        public decimal CDIMOCRqms
        {
            get
            {
                return this.cDIMOCRqmsField;
            }
            set
            {
                this.cDIMOCRqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIMOCRqmsSpecified
        {
            get
            {
                return this.cDIMOCRqmsFieldSpecified;
            }
            set
            {
                this.cDIMOCRqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=39)]
        public int IFERqms
        {
            get
            {
                return this.iFERqmsField;
            }
            set
            {
                this.iFERqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IFERqmsSpecified
        {
            get
            {
                return this.iFERqmsFieldSpecified;
            }
            set
            {
                this.iFERqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=40)]
        public decimal CDIFERqms
        {
            get
            {
                return this.cDIFERqmsField;
            }
            set
            {
                this.cDIFERqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIFERqmsSpecified
        {
            get
            {
                return this.cDIFERqmsFieldSpecified;
            }
            set
            {
                this.cDIFERqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=41)]
        public int IVELqms
        {
            get
            {
                return this.iVELqmsField;
            }
            set
            {
                this.iVELqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IVELqmsSpecified
        {
            get
            {
                return this.iVELqmsFieldSpecified;
            }
            set
            {
                this.iVELqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=42)]
        public decimal CDIVELqms
        {
            get
            {
                return this.cDIVELqmsField;
            }
            set
            {
                this.cDIVELqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIVELqmsSpecified
        {
            get
            {
                return this.cDIVELqmsFieldSpecified;
            }
            set
            {
                this.cDIVELqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=43)]
        public int IMERqms
        {
            get
            {
                return this.iMERqmsField;
            }
            set
            {
                this.iMERqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IMERqmsSpecified
        {
            get
            {
                return this.iMERqmsFieldSpecified;
            }
            set
            {
                this.iMERqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=44)]
        public decimal CDIMERqms
        {
            get
            {
                return this.cDIMERqmsField;
            }
            set
            {
                this.cDIMERqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIMERqmsSpecified
        {
            get
            {
                return this.cDIMERqmsFieldSpecified;
            }
            set
            {
                this.cDIMERqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=45)]
        public int IQMqms
        {
            get
            {
                return this.iQMqmsField;
            }
            set
            {
                this.iQMqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IQMqmsSpecified
        {
            get
            {
                return this.iQMqmsFieldSpecified;
            }
            set
            {
                this.iQMqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=46)]
        public decimal CDIQMqms
        {
            get
            {
                return this.cDIQMqmsField;
            }
            set
            {
                this.cDIQMqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIQMqmsSpecified
        {
            get
            {
                return this.cDIQMqmsFieldSpecified;
            }
            set
            {
                this.cDIQMqmsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=47)]
        public string DEEqms
        {
            get
            {
                return this.dEEqmsField;
            }
            set
            {
                this.dEEqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=48)]
        public string LADqms
        {
            get
            {
                return this.lADqmsField;
            }
            set
            {
                this.lADqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=49)]
        public string ARCqms
        {
            get
            {
                return this.aRCqmsField;
            }
            set
            {
                this.aRCqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=50)]
        public string LACqms
        {
            get
            {
                return this.lACqmsField;
            }
            set
            {
                this.lACqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=51)]
        public string EPDqms
        {
            get
            {
                return this.ePDqmsField;
            }
            set
            {
                this.ePDqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=52)]
        public string GRCqms
        {
            get
            {
                return this.gRCqmsField;
            }
            set
            {
                this.gRCqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=53)]
        public string LODqms
        {
            get
            {
                return this.lODqmsField;
            }
            set
            {
                this.lODqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=54)]
        public string LOBqms
        {
            get
            {
                return this.lOBqmsField;
            }
            set
            {
                this.lOBqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=55)]
        public string LAHqms
        {
            get
            {
                return this.lAHqmsField;
            }
            set
            {
                this.lAHqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=56)]
        public string DEVqms
        {
            get
            {
                return this.dEVqmsField;
            }
            set
            {
                this.dEVqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=57)]
        public string TETqms
        {
            get
            {
                return this.tETqmsField;
            }
            set
            {
                this.tETqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=58)]
        public string AAVqms
        {
            get
            {
                return this.aAVqmsField;
            }
            set
            {
                this.aAVqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=59)]
        public string AARqms
        {
            get
            {
                return this.aARqmsField;
            }
            set
            {
                this.aARqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=60)]
        public string REDqms
        {
            get
            {
                return this.rEDqmsField;
            }
            set
            {
                this.rEDqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=61)]
        public string ETAqms
        {
            get
            {
                return this.eTAqmsField;
            }
            set
            {
                this.eTAqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=62)]
        public string LOCqms
        {
            get
            {
                return this.lOCqmsField;
            }
            set
            {
                this.lOCqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=63)]
        public string LATqms
        {
            get
            {
                return this.lATqmsField;
            }
            set
            {
                this.lATqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=64)]
        public string LAPqms
        {
            get
            {
                return this.lAPqmsField;
            }
            set
            {
                this.lAPqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=65)]
        public string PPOqms
        {
            get
            {
                return this.pPOqmsField;
            }
            set
            {
                this.pPOqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=66)]
        public string HARqms
        {
            get
            {
                return this.hARqmsField;
            }
            set
            {
                this.hARqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=67)]
        public string POIqms
        {
            get
            {
                return this.pOIqmsField;
            }
            set
            {
                this.pOIqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=68)]
        public string LAIqms
        {
            get
            {
                return this.lAIqmsField;
            }
            set
            {
                this.lAIqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=69)]
        public string BASqms
        {
            get
            {
                return this.bASqmsField;
            }
            set
            {
                this.bASqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=70)]
        public string EXTqms
        {
            get
            {
                return this.eXTqmsField;
            }
            set
            {
                this.eXTqmsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=71)]
        public string COUqms
        {
            get
            {
                return this.cOUqmsField;
            }
            set
            {
                this.cOUqmsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexCDVeauBoucherie
    {
        
        private string baseReferenceField;
        
        private int cRvbsField;
        
        private bool cRvbsFieldSpecified;
        
        private decimal cDCRvbsField;
        
        private bool cDCRvbsFieldSpecified;
        
        private int dMvbsField;
        
        private bool dMvbsFieldSpecified;
        
        private decimal cDDMvbsField;
        
        private bool cDDMvbsFieldSpecified;
        
        private int vENTvbsField;
        
        private bool vENTvbsFieldSpecified;
        
        private decimal cDVENTvbsField;
        
        private bool cDVENTvbsFieldSpecified;
        
        private int fOSvbsField;
        
        private bool fOSvbsFieldSpecified;
        
        private decimal cDFOSvbsField;
        
        private bool cDFOSvbsFieldSpecified;
        
        private int iABVvbsField;
        
        private bool iABVvbsFieldSpecified;
        
        private decimal cDIABVvbsField;
        
        private bool cDIABVvbsFieldSpecified;
        
        private int pCARvbsField;
        
        private bool pCARvbsFieldSpecified;
        
        private decimal cDPCARvbsField;
        
        private bool cDPCARvbsFieldSpecified;
        
        private int rDTvbsField;
        
        private bool rDTvbsFieldSpecified;
        
        private decimal cDRDTvbsField;
        
        private bool cDRDTvbsFieldSpecified;
        
        private int cONFvbsField;
        
        private bool cONFvbsFieldSpecified;
        
        private decimal cDCONFvbsField;
        
        private bool cDCONFvbsFieldSpecified;
        
        private int cECvbsField;
        
        private bool cECvbsFieldSpecified;
        
        private decimal cDCECvbsField;
        
        private bool cDCECvbsFieldSpecified;
        
        private int cDCvbsField;
        
        private bool cDCvbsFieldSpecified;
        
        private decimal cDCDCvbsField;
        
        private bool cDCDCvbsFieldSpecified;
        
        private int cACvbsField;
        
        private bool cACvbsFieldSpecified;
        
        private decimal cDCACvbsField;
        
        private bool cDCACvbsFieldSpecified;
        
        private int cCUvbsField;
        
        private bool cCUvbsFieldSpecified;
        
        private decimal cDCCUvbsField;
        
        private bool cDCCUvbsFieldSpecified;
        
        private int cCAvbsField;
        
        private bool cCAvbsFieldSpecified;
        
        private decimal cDCCAvbsField;
        
        private bool cDCCAvbsFieldSpecified;
        
        private int cOULvbsField;
        
        private bool cOULvbsFieldSpecified;
        
        private decimal cDCOULvbsField;
        
        private bool cDCOULvbsFieldSpecified;
        
        private int gRASvbsField;
        
        private bool gRASvbsFieldSpecified;
        
        private decimal cDGRASvbsField;
        
        private bool cDGRASvbsFieldSpecified;
        
        private int iABvbsField;
        
        private bool iABvbsFieldSpecified;
        
        private decimal cDIABvbsField;
        
        private bool cDIABvbsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string BaseReference
        {
            get
            {
                return this.baseReferenceField;
            }
            set
            {
                this.baseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int CRvbs
        {
            get
            {
                return this.cRvbsField;
            }
            set
            {
                this.cRvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRvbsSpecified
        {
            get
            {
                return this.cRvbsFieldSpecified;
            }
            set
            {
                this.cRvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal CDCRvbs
        {
            get
            {
                return this.cDCRvbsField;
            }
            set
            {
                this.cDCRvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRvbsSpecified
        {
            get
            {
                return this.cDCRvbsFieldSpecified;
            }
            set
            {
                this.cDCRvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int DMvbs
        {
            get
            {
                return this.dMvbsField;
            }
            set
            {
                this.dMvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMvbsSpecified
        {
            get
            {
                return this.dMvbsFieldSpecified;
            }
            set
            {
                this.dMvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal CDDMvbs
        {
            get
            {
                return this.cDDMvbsField;
            }
            set
            {
                this.cDDMvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDMvbsSpecified
        {
            get
            {
                return this.cDDMvbsFieldSpecified;
            }
            set
            {
                this.cDDMvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int VENTvbs
        {
            get
            {
                return this.vENTvbsField;
            }
            set
            {
                this.vENTvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VENTvbsSpecified
        {
            get
            {
                return this.vENTvbsFieldSpecified;
            }
            set
            {
                this.vENTvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal CDVENTvbs
        {
            get
            {
                return this.cDVENTvbsField;
            }
            set
            {
                this.cDVENTvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDVENTvbsSpecified
        {
            get
            {
                return this.cDVENTvbsFieldSpecified;
            }
            set
            {
                this.cDVENTvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int FOSvbs
        {
            get
            {
                return this.fOSvbsField;
            }
            set
            {
                this.fOSvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FOSvbsSpecified
        {
            get
            {
                return this.fOSvbsFieldSpecified;
            }
            set
            {
                this.fOSvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal CDFOSvbs
        {
            get
            {
                return this.cDFOSvbsField;
            }
            set
            {
                this.cDFOSvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDFOSvbsSpecified
        {
            get
            {
                return this.cDFOSvbsFieldSpecified;
            }
            set
            {
                this.cDFOSvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int IABVvbs
        {
            get
            {
                return this.iABVvbsField;
            }
            set
            {
                this.iABVvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABVvbsSpecified
        {
            get
            {
                return this.iABVvbsFieldSpecified;
            }
            set
            {
                this.iABVvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public decimal CDIABVvbs
        {
            get
            {
                return this.cDIABVvbsField;
            }
            set
            {
                this.cDIABVvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIABVvbsSpecified
        {
            get
            {
                return this.cDIABVvbsFieldSpecified;
            }
            set
            {
                this.cDIABVvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int PCARvbs
        {
            get
            {
                return this.pCARvbsField;
            }
            set
            {
                this.pCARvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PCARvbsSpecified
        {
            get
            {
                return this.pCARvbsFieldSpecified;
            }
            set
            {
                this.pCARvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public decimal CDPCARvbs
        {
            get
            {
                return this.cDPCARvbsField;
            }
            set
            {
                this.cDPCARvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDPCARvbsSpecified
        {
            get
            {
                return this.cDPCARvbsFieldSpecified;
            }
            set
            {
                this.cDPCARvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int RDTvbs
        {
            get
            {
                return this.rDTvbsField;
            }
            set
            {
                this.rDTvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RDTvbsSpecified
        {
            get
            {
                return this.rDTvbsFieldSpecified;
            }
            set
            {
                this.rDTvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public decimal CDRDTvbs
        {
            get
            {
                return this.cDRDTvbsField;
            }
            set
            {
                this.cDRDTvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDRDTvbsSpecified
        {
            get
            {
                return this.cDRDTvbsFieldSpecified;
            }
            set
            {
                this.cDRDTvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int CONFvbs
        {
            get
            {
                return this.cONFvbsField;
            }
            set
            {
                this.cONFvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CONFvbsSpecified
        {
            get
            {
                return this.cONFvbsFieldSpecified;
            }
            set
            {
                this.cONFvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public decimal CDCONFvbs
        {
            get
            {
                return this.cDCONFvbsField;
            }
            set
            {
                this.cDCONFvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCONFvbsSpecified
        {
            get
            {
                return this.cDCONFvbsFieldSpecified;
            }
            set
            {
                this.cDCONFvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int CECvbs
        {
            get
            {
                return this.cECvbsField;
            }
            set
            {
                this.cECvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CECvbsSpecified
        {
            get
            {
                return this.cECvbsFieldSpecified;
            }
            set
            {
                this.cECvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public decimal CDCECvbs
        {
            get
            {
                return this.cDCECvbsField;
            }
            set
            {
                this.cDCECvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCECvbsSpecified
        {
            get
            {
                return this.cDCECvbsFieldSpecified;
            }
            set
            {
                this.cDCECvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int CDCvbs
        {
            get
            {
                return this.cDCvbsField;
            }
            set
            {
                this.cDCvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCvbsSpecified
        {
            get
            {
                return this.cDCvbsFieldSpecified;
            }
            set
            {
                this.cDCvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public decimal CDCDCvbs
        {
            get
            {
                return this.cDCDCvbsField;
            }
            set
            {
                this.cDCDCvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCDCvbsSpecified
        {
            get
            {
                return this.cDCDCvbsFieldSpecified;
            }
            set
            {
                this.cDCDCvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int CACvbs
        {
            get
            {
                return this.cACvbsField;
            }
            set
            {
                this.cACvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CACvbsSpecified
        {
            get
            {
                return this.cACvbsFieldSpecified;
            }
            set
            {
                this.cACvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public decimal CDCACvbs
        {
            get
            {
                return this.cDCACvbsField;
            }
            set
            {
                this.cDCACvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCACvbsSpecified
        {
            get
            {
                return this.cDCACvbsFieldSpecified;
            }
            set
            {
                this.cDCACvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public int CCUvbs
        {
            get
            {
                return this.cCUvbsField;
            }
            set
            {
                this.cCUvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CCUvbsSpecified
        {
            get
            {
                return this.cCUvbsFieldSpecified;
            }
            set
            {
                this.cCUvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public decimal CDCCUvbs
        {
            get
            {
                return this.cDCCUvbsField;
            }
            set
            {
                this.cDCCUvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCCUvbsSpecified
        {
            get
            {
                return this.cDCCUvbsFieldSpecified;
            }
            set
            {
                this.cDCCUvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public int CCAvbs
        {
            get
            {
                return this.cCAvbsField;
            }
            set
            {
                this.cCAvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CCAvbsSpecified
        {
            get
            {
                return this.cCAvbsFieldSpecified;
            }
            set
            {
                this.cCAvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public decimal CDCCAvbs
        {
            get
            {
                return this.cDCCAvbsField;
            }
            set
            {
                this.cDCCAvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCCAvbsSpecified
        {
            get
            {
                return this.cDCCAvbsFieldSpecified;
            }
            set
            {
                this.cDCCAvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public int COULvbs
        {
            get
            {
                return this.cOULvbsField;
            }
            set
            {
                this.cOULvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool COULvbsSpecified
        {
            get
            {
                return this.cOULvbsFieldSpecified;
            }
            set
            {
                this.cOULvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public decimal CDCOULvbs
        {
            get
            {
                return this.cDCOULvbsField;
            }
            set
            {
                this.cDCOULvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCOULvbsSpecified
        {
            get
            {
                return this.cDCOULvbsFieldSpecified;
            }
            set
            {
                this.cDCOULvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public int GRASvbs
        {
            get
            {
                return this.gRASvbsField;
            }
            set
            {
                this.gRASvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GRASvbsSpecified
        {
            get
            {
                return this.gRASvbsFieldSpecified;
            }
            set
            {
                this.gRASvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public decimal CDGRASvbs
        {
            get
            {
                return this.cDGRASvbsField;
            }
            set
            {
                this.cDGRASvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDGRASvbsSpecified
        {
            get
            {
                return this.cDGRASvbsFieldSpecified;
            }
            set
            {
                this.cDGRASvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public int IABvbs
        {
            get
            {
                return this.iABvbsField;
            }
            set
            {
                this.iABvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABvbsSpecified
        {
            get
            {
                return this.iABvbsFieldSpecified;
            }
            set
            {
                this.iABvbsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public decimal CDIABvbs
        {
            get
            {
                return this.cDIABvbsField;
            }
            set
            {
                this.cDIABvbsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIABvbsSpecified
        {
            get
            {
                return this.cDIABvbsFieldSpecified;
            }
            set
            {
                this.cDIABvbsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IndexControleStationsSECI
    {
        
        private string codeStationField;
        
        private string codeRaceProgrammeField;
        
        private TypeCodeTypeProgramme typeProgrammeField;
        
        private string campagneEntreeStationField;
        
        private string numeroSerieCampagneField;
        
        private string indicateurAnimalEvalueField;
        
        private string baseReferenceField;
        
        private int cRseCRciField;
        
        private bool cRseCRciFieldSpecified;
        
        private decimal cDCRseCRciField;
        
        private bool cDCRseCRciFieldSpecified;
        
        private int vOSseVOSciField;
        
        private bool vOSseVOSciFieldSpecified;
        
        private decimal cDVOSseVOSciField;
        
        private bool cDVOSseVOSciFieldSpecified;
        
        private int eFAciField;
        
        private bool eFAciFieldSpecified;
        
        private decimal cDEFAciField;
        
        private bool cDEFAciFieldSpecified;
        
        private int dMseDMciField;
        
        private bool dMseDMciFieldSpecified;
        
        private decimal cDDMseDMciField;
        
        private bool cDDMseDMciFieldSpecified;
        
        private int dSseDSciField;
        
        private bool dSseDSciFieldSpecified;
        
        private decimal cDDSseDSciField;
        
        private bool cDDSseDSciFieldSpecified;
        
        private int aFseAFciField;
        
        private bool aFseAFciFieldSpecified;
        
        private decimal cDAFseAFciField;
        
        private bool cDAFseAFciFieldSpecified;
        
        private int qRseQRciField;
        
        private bool qRseQRciFieldSpecified;
        
        private decimal cDQRseQRciField;
        
        private bool cDQRseQRciFieldSpecified;
        
        private int iABVseIABVciField;
        
        private bool iABVseIABVciFieldSpecified;
        
        private decimal cDIABVseIABVciField;
        
        private bool cDIABVseIABVciFieldSpecified;
        
        private int iMOCRseIMOCRciField;
        
        private bool iMOCRseIMOCRciFieldSpecified;
        
        private decimal cDIMOCRseIMOCRciField;
        
        private bool cDIMOCRseIMOCRciFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodeStation
        {
            get
            {
                return this.codeStationField;
            }
            set
            {
                this.codeStationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string CodeRaceProgramme
        {
            get
            {
                return this.codeRaceProgrammeField;
            }
            set
            {
                this.codeRaceProgrammeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TypeCodeTypeProgramme TypeProgramme
        {
            get
            {
                return this.typeProgrammeField;
            }
            set
            {
                this.typeProgrammeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string CampagneEntreeStation
        {
            get
            {
                return this.campagneEntreeStationField;
            }
            set
            {
                this.campagneEntreeStationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string NumeroSerieCampagne
        {
            get
            {
                return this.numeroSerieCampagneField;
            }
            set
            {
                this.numeroSerieCampagneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string IndicateurAnimalEvalue
        {
            get
            {
                return this.indicateurAnimalEvalueField;
            }
            set
            {
                this.indicateurAnimalEvalueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string BaseReference
        {
            get
            {
                return this.baseReferenceField;
            }
            set
            {
                this.baseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int CRseCRci
        {
            get
            {
                return this.cRseCRciField;
            }
            set
            {
                this.cRseCRciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CRseCRciSpecified
        {
            get
            {
                return this.cRseCRciFieldSpecified;
            }
            set
            {
                this.cRseCRciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal CDCRseCRci
        {
            get
            {
                return this.cDCRseCRciField;
            }
            set
            {
                this.cDCRseCRciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDCRseCRciSpecified
        {
            get
            {
                return this.cDCRseCRciFieldSpecified;
            }
            set
            {
                this.cDCRseCRciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int VOSseVOSci
        {
            get
            {
                return this.vOSseVOSciField;
            }
            set
            {
                this.vOSseVOSciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VOSseVOSciSpecified
        {
            get
            {
                return this.vOSseVOSciFieldSpecified;
            }
            set
            {
                this.vOSseVOSciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public decimal CDVOSseVOSci
        {
            get
            {
                return this.cDVOSseVOSciField;
            }
            set
            {
                this.cDVOSseVOSciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDVOSseVOSciSpecified
        {
            get
            {
                return this.cDVOSseVOSciFieldSpecified;
            }
            set
            {
                this.cDVOSseVOSciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int EFAci
        {
            get
            {
                return this.eFAciField;
            }
            set
            {
                this.eFAciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EFAciSpecified
        {
            get
            {
                return this.eFAciFieldSpecified;
            }
            set
            {
                this.eFAciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public decimal CDEFAci
        {
            get
            {
                return this.cDEFAciField;
            }
            set
            {
                this.cDEFAciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDEFAciSpecified
        {
            get
            {
                return this.cDEFAciFieldSpecified;
            }
            set
            {
                this.cDEFAciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public int DMseDMci
        {
            get
            {
                return this.dMseDMciField;
            }
            set
            {
                this.dMseDMciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DMseDMciSpecified
        {
            get
            {
                return this.dMseDMciFieldSpecified;
            }
            set
            {
                this.dMseDMciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public decimal CDDMseDMci
        {
            get
            {
                return this.cDDMseDMciField;
            }
            set
            {
                this.cDDMseDMciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDMseDMciSpecified
        {
            get
            {
                return this.cDDMseDMciFieldSpecified;
            }
            set
            {
                this.cDDMseDMciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int DSseDSci
        {
            get
            {
                return this.dSseDSciField;
            }
            set
            {
                this.dSseDSciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DSseDSciSpecified
        {
            get
            {
                return this.dSseDSciFieldSpecified;
            }
            set
            {
                this.dSseDSciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public decimal CDDSseDSci
        {
            get
            {
                return this.cDDSseDSciField;
            }
            set
            {
                this.cDDSseDSciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDDSseDSciSpecified
        {
            get
            {
                return this.cDDSseDSciFieldSpecified;
            }
            set
            {
                this.cDDSseDSciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public int AFseAFci
        {
            get
            {
                return this.aFseAFciField;
            }
            set
            {
                this.aFseAFciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AFseAFciSpecified
        {
            get
            {
                return this.aFseAFciFieldSpecified;
            }
            set
            {
                this.aFseAFciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public decimal CDAFseAFci
        {
            get
            {
                return this.cDAFseAFciField;
            }
            set
            {
                this.cDAFseAFciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDAFseAFciSpecified
        {
            get
            {
                return this.cDAFseAFciFieldSpecified;
            }
            set
            {
                this.cDAFseAFciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public int QRseQRci
        {
            get
            {
                return this.qRseQRciField;
            }
            set
            {
                this.qRseQRciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QRseQRciSpecified
        {
            get
            {
                return this.qRseQRciFieldSpecified;
            }
            set
            {
                this.qRseQRciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public decimal CDQRseQRci
        {
            get
            {
                return this.cDQRseQRciField;
            }
            set
            {
                this.cDQRseQRciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDQRseQRciSpecified
        {
            get
            {
                return this.cDQRseQRciFieldSpecified;
            }
            set
            {
                this.cDQRseQRciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public int IABVseIABVci
        {
            get
            {
                return this.iABVseIABVciField;
            }
            set
            {
                this.iABVseIABVciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IABVseIABVciSpecified
        {
            get
            {
                return this.iABVseIABVciFieldSpecified;
            }
            set
            {
                this.iABVseIABVciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public decimal CDIABVseIABVci
        {
            get
            {
                return this.cDIABVseIABVciField;
            }
            set
            {
                this.cDIABVseIABVciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIABVseIABVciSpecified
        {
            get
            {
                return this.cDIABVseIABVciFieldSpecified;
            }
            set
            {
                this.cDIABVseIABVciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public int IMOCRseIMOCRci
        {
            get
            {
                return this.iMOCRseIMOCRciField;
            }
            set
            {
                this.iMOCRseIMOCRciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IMOCRseIMOCRciSpecified
        {
            get
            {
                return this.iMOCRseIMOCRciFieldSpecified;
            }
            set
            {
                this.iMOCRseIMOCRciFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public decimal CDIMOCRseIMOCRci
        {
            get
            {
                return this.cDIMOCRseIMOCRciField;
            }
            set
            {
                this.cDIMOCRseIMOCRciField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CDIMOCRseIMOCRciSpecified
        {
            get
            {
                return this.cDIMOCRseIMOCRciFieldSpecified;
            }
            set
            {
                this.cDIMOCRseIMOCRciFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeTypeProgramme:1")]
    public enum TypeCodeTypeProgramme
    {
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        I,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class RefusCertification
    {
        
        private Bovin mereRefuseeField;
        
        private Bovin pereRefuseField;
        
        private string causeRefusCertificationField;
        
        private System.DateTime dateRefusCertificationField;
        
        private System.DateTime dateLeveeRefusField;
        
        private bool dateLeveeRefusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Bovin MereRefusee
        {
            get
            {
                return this.mereRefuseeField;
            }
            set
            {
                this.mereRefuseeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Bovin PereRefuse
        {
            get
            {
                return this.pereRefuseField;
            }
            set
            {
                this.pereRefuseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CauseRefusCertification
        {
            get
            {
                return this.causeRefusCertificationField;
            }
            set
            {
                this.causeRefusCertificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=3)]
        public System.DateTime DateRefusCertification
        {
            get
            {
                return this.dateRefusCertificationField;
            }
            set
            {
                this.dateRefusCertificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=4)]
        public System.DateTime DateLeveeRefus
        {
            get
            {
                return this.dateLeveeRefusField;
            }
            set
            {
                this.dateLeveeRefusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateLeveeRefusSpecified
        {
            get
            {
                return this.dateLeveeRefusFieldSpecified;
            }
            set
            {
                this.dateLeveeRefusFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinTiers
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementAnimalTiers[] evenementAnimalTiersField;
        
        private DonneeElaboreeAnimalTiers[] donneeElaboreeAnimalTiersField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementAnimalTiers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementAnimalTiers[] EvenementAnimalTiers
        {
            get
            {
                return this.evenementAnimalTiersField;
            }
            set
            {
                this.evenementAnimalTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DonneeElaboreeAnimalTiers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public DonneeElaboreeAnimalTiers[] DonneeElaboreeAnimalTiers
        {
            get
            {
                return this.donneeElaboreeAnimalTiersField;
            }
            set
            {
                this.donneeElaboreeAnimalTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageMdBDonneesOrganismeTiers
    {
        
        private InformationsMessage informationsMessageField;
        
        private PassageControleLaitierTiers[] passageControleLaitierTiersField;
        
        private BovinTiers[] bovinTiersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassageControleLaitierTiers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public PassageControleLaitierTiers[] PassageControleLaitierTiers
        {
            get
            {
                return this.passageControleLaitierTiersField;
            }
            set
            {
                this.passageControleLaitierTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinTiers", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public BovinTiers[] BovinTiers
        {
            get
            {
                return this.bovinTiersField;
            }
            set
            {
                this.bovinTiersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class InformationsMessage
    {
        
        private typeIdentifiantExploitation exploitationField;
        
        private System.DateTime dateDebutDemandeField;
        
        private System.DateTime dateFinDemandeField;
        
        private bool dateFinDemandeFieldSpecified;
        
        private Organisation organismeTiersDemandeurField;
        
        private TaureauReproducteur[] taureauReproducteurField;
        
        private string raceDemandeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public typeIdentifiantExploitation Exploitation
        {
            get
            {
                return this.exploitationField;
            }
            set
            {
                this.exploitationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=1)]
        public System.DateTime DateDebutDemande
        {
            get
            {
                return this.dateDebutDemandeField;
            }
            set
            {
                this.dateDebutDemandeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=2)]
        public System.DateTime DateFinDemande
        {
            get
            {
                return this.dateFinDemandeField;
            }
            set
            {
                this.dateFinDemandeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateFinDemandeSpecified
        {
            get
            {
                return this.dateFinDemandeFieldSpecified;
            }
            set
            {
                this.dateFinDemandeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public Organisation OrganismeTiersDemandeur
        {
            get
            {
                return this.organismeTiersDemandeurField;
            }
            set
            {
                this.organismeTiersDemandeurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaureauReproducteur", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public TaureauReproducteur[] TaureauReproducteur
        {
            get
            {
                return this.taureauReproducteurField;
            }
            set
            {
                this.taureauReproducteurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string RaceDemande
        {
            get
            {
                return this.raceDemandeField;
            }
            set
            {
                this.raceDemandeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinCPV
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementsAnimauxCPV[] evenementsAnimauxCPVField;
        
        private DonneesElaboreesAnimalCPV[] donneesElaboreesAnimalCPVField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementsAnimauxCPV", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxCPV[] EvenementsAnimauxCPV
        {
            get
            {
                return this.evenementsAnimauxCPVField;
            }
            set
            {
                this.evenementsAnimauxCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DonneesElaboreesAnimalCPV", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public DonneesElaboreesAnimalCPV[] DonneesElaboreesAnimalCPV
        {
            get
            {
                return this.donneesElaboreesAnimalCPVField;
            }
            set
            {
                this.donneesElaboreesAnimalCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageVaBDonneesCPV
    {
        
        private InformationsMessage informationsMessageField;
        
        private BovinCPV[] bovinCPVField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinCPV", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public BovinCPV[] BovinCPV
        {
            get
            {
                return this.bovinCPVField;
            }
            set
            {
                this.bovinCPVField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinCL
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementsAnimauxCL[] evenementsAnimauxCLField;
        
        private DonneesElaboreesAnimalCL[] donneesElaboreesAnimalCLField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementsAnimauxCL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxCL[] EvenementsAnimauxCL
        {
            get
            {
                return this.evenementsAnimauxCLField;
            }
            set
            {
                this.evenementsAnimauxCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DonneesElaboreesAnimalCL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public DonneesElaboreesAnimalCL[] DonneesElaboreesAnimalCL
        {
            get
            {
                return this.donneesElaboreesAnimalCLField;
            }
            set
            {
                this.donneesElaboreesAnimalCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageClBDonneesCL
    {
        
        private InformationsMessage informationsMessageField;
        
        private PassageControleLaitier[] passageControleLaitierField;
        
        private BovinCL[] bovinCLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassageControleLaitier", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public PassageControleLaitier[] PassageControleLaitier
        {
            get
            {
                return this.passageControleLaitierField;
            }
            set
            {
                this.passageControleLaitierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinCL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public BovinCL[] BovinCL
        {
            get
            {
                return this.bovinCLField;
            }
            set
            {
                this.bovinCLField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinCPB
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementsAnimauxCPB[] evenementsAnimauxCPBField;
        
        private DonneesElaboreesAnimalCPB[] donneesElaboreesAnimalCPBField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementsAnimauxCPB", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxCPB[] EvenementsAnimauxCPB
        {
            get
            {
                return this.evenementsAnimauxCPBField;
            }
            set
            {
                this.evenementsAnimauxCPBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DonneesElaboreesAnimalCPB", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public DonneesElaboreesAnimalCPB[] DonneesElaboreesAnimalCPB
        {
            get
            {
                return this.donneesElaboreesAnimalCPBField;
            }
            set
            {
                this.donneesElaboreesAnimalCPBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageCpBDonneesCPB
    {
        
        private InformationsMessage informationsMessageField;
        
        private BovinCPB[] bovinCPBField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinCPB", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public BovinCPB[] BovinCPB
        {
            get
            {
                return this.bovinCPBField;
            }
            set
            {
                this.bovinCPBField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinTE
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementsAnimauxTE[] evenementsAnimauxTEField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementsAnimauxTE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxTE[] EvenementsAnimauxTE
        {
            get
            {
                return this.evenementsAnimauxTEField;
            }
            set
            {
                this.evenementsAnimauxTEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageTkBDonneesTE
    {
        
        private InformationsMessage informationsMessageField;
        
        private BovinTE[] bovinTEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinTE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public BovinTE[] BovinTE
        {
            get
            {
                return this.bovinTEField;
            }
            set
            {
                this.bovinTEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinIA
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementsAnimauxIA[] evenementsAnimauxIAField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementsAnimauxIA", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxIA[] EvenementsAnimauxIA
        {
            get
            {
                return this.evenementsAnimauxIAField;
            }
            set
            {
                this.evenementsAnimauxIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageIaBDonneesIA
    {
        
        private InformationsMessage informationsMessageField;
        
        private BovinIA[] bovinIAField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinIA", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public BovinIA[] BovinIA
        {
            get
            {
                return this.bovinIAField;
            }
            set
            {
                this.bovinIAField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageMdBDonneesGenetiquesAnimales
    {
        
        private InformationsMessage informationsMessageField;
        
        private PassageControleLaitier[] passageControleLaitierField;
        
        private Bovin[] bovinField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassageControleLaitier", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public PassageControleLaitier[] PassageControleLaitier
        {
            get
            {
                return this.passageControleLaitierField;
            }
            set
            {
                this.passageControleLaitierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bovin", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Bovin[] Bovin
        {
            get
            {
                return this.bovinField;
            }
            set
            {
                this.bovinField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class typeAnimalEnErreur
    {
        
        private TypeCodePays codePaysAnimalField;
        
        private string numeroAnimalField;
        
        private typeAnomalie anomalieField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePaysAnimal
        {
            get
            {
                return this.codePaysAnimalField;
            }
            set
            {
                this.codePaysAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroAnimal
        {
            get
            {
                return this.numeroAnimalField;
            }
            set
            {
                this.numeroAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageMdBDonneesMalesPublics
    {
        
        private InformationsMessage informationsMessageField;
        
        private DeclarationInitialeMalePublic[] declarationInitialeField;
        
        private typeAnimalEnErreur[] taureauEnErreurField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeclarationInitiale", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public DeclarationInitialeMalePublic[] DeclarationInitiale
        {
            get
            {
                return this.declarationInitialeField;
            }
            set
            {
                this.declarationInitialeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaureauEnErreur", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public typeAnimalEnErreur[] TaureauEnErreur
        {
            get
            {
                return this.taureauEnErreurField;
            }
            set
            {
                this.taureauEnErreurField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ReferenceVisitePointage
    {
        
        private string codeRaceVisiteField;
        
        private string versionTablePointageField;
        
        private string numeroPostePointageField;
        
        private string libellePostePointageField;
        
        private string abreviationPostePointageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string CodeRaceVisite
        {
            get
            {
                return this.codeRaceVisiteField;
            }
            set
            {
                this.codeRaceVisiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string VersionTablePointage
        {
            get
            {
                return this.versionTablePointageField;
            }
            set
            {
                this.versionTablePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NumeroPostePointage
        {
            get
            {
                return this.numeroPostePointageField;
            }
            set
            {
                this.numeroPostePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string LibellePostePointage
        {
            get
            {
                return this.libellePostePointageField;
            }
            set
            {
                this.libellePostePointageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string AbreviationPostePointage
        {
            get
            {
                return this.abreviationPostePointageField;
            }
            set
            {
                this.abreviationPostePointageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class Qualification
    {
        
        private string raceQualificationField;
        
        private string libelleQualificationField;
        
        private string codeConseilUtilisationField;
        
        private System.DateTime dateExamenField;
        
        private bool dateExamenFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string RaceQualification
        {
            get
            {
                return this.raceQualificationField;
            }
            set
            {
                this.raceQualificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string LibelleQualification
        {
            get
            {
                return this.libelleQualificationField;
            }
            set
            {
                this.libelleQualificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string CodeConseilUtilisation
        {
            get
            {
                return this.codeConseilUtilisationField;
            }
            set
            {
                this.codeConseilUtilisationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=3)]
        public System.DateTime DateExamen
        {
            get
            {
                return this.dateExamenField;
            }
            set
            {
                this.dateExamenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateExamenSpecified
        {
            get
            {
                return this.dateExamenFieldSpecified;
            }
            set
            {
                this.dateExamenFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class InscriptionLivreGenealogique
    {
        
        private string raceLivreGenealogiqueField;
        
        private TypeCodeSection codeSectionField;
        
        private TypeClasseMerite classeMeriteField;
        
        private bool classeMeriteFieldSpecified;
        
        private string typeCertificatEditeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string RaceLivreGenealogique
        {
            get
            {
                return this.raceLivreGenealogiqueField;
            }
            set
            {
                this.raceLivreGenealogiqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TypeCodeSection CodeSection
        {
            get
            {
                return this.codeSectionField;
            }
            set
            {
                this.codeSectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public TypeClasseMerite ClasseMerite
        {
            get
            {
                return this.classeMeriteField;
            }
            set
            {
                this.classeMeriteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClasseMeriteSpecified
        {
            get
            {
                return this.classeMeriteFieldSpecified;
            }
            set
            {
                this.classeMeriteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string TypeCertificatEdite
        {
            get
            {
                return this.typeCertificatEditeField;
            }
            set
            {
                this.typeCertificatEditeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:CodeSection:1")]
    public enum TypeCodeSection
    {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:fr:agri:elevage:codelist:ClasseMerite:1")]
    public enum TypeClasseMerite
    {
        
        /// <remarks/>
        CPB,
        
        /// <remarks/>
        EPREU0,
        
        /// <remarks/>
        EPREU1,
        
        /// <remarks/>
        EPREU2,
        
        /// <remarks/>
        EPREUV,
        
        /// <remarks/>
        HISTOR,
        
        /// <remarks/>
        INIREG,
        
        /// <remarks/>
        ORIAUT,
        
        /// <remarks/>
        ORIPER,
        
        /// <remarks/>
        SAET1F,
        
        /// <remarks/>
        SAET1M,
        
        /// <remarks/>
        SAET2F,
        
        /// <remarks/>
        SAET2M,
        
        /// <remarks/>
        SAET3F,
        
        /// <remarks/>
        SAET3M,
        
        /// <remarks/>
        SPET1F,
        
        /// <remarks/>
        SPET1M,
        
        /// <remarks/>
        SPET2F,
        
        /// <remarks/>
        SPET2M,
        
        /// <remarks/>
        SPET3F,
        
        /// <remarks/>
        SPET3M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class DonneesElaboreesAnimalRAC
    {
        
        private Organisation createurField;
        
        private InscriptionLivreGenealogique inscriptionLivreGenealogiqueField;
        
        private Qualification qualificationField;
        
        private System.DateTime dateElaborationField;
        
        private bool dateElaborationFieldSpecified;
        
        private bool codeSuppressionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Organisation Createur
        {
            get
            {
                return this.createurField;
            }
            set
            {
                this.createurField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public InscriptionLivreGenealogique InscriptionLivreGenealogique
        {
            get
            {
                return this.inscriptionLivreGenealogiqueField;
            }
            set
            {
                this.inscriptionLivreGenealogiqueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Qualification Qualification
        {
            get
            {
                return this.qualificationField;
            }
            set
            {
                this.qualificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date", Order=3)]
        public System.DateTime DateElaboration
        {
            get
            {
                return this.dateElaborationField;
            }
            set
            {
                this.dateElaborationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateElaborationSpecified
        {
            get
            {
                return this.dateElaborationFieldSpecified;
            }
            set
            {
                this.dateElaborationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class BovinRAC
    {
        
        private TypeCodePays codePaysField;
        
        private string numeroNationalAnimalField;
        
        private Identite identiteField;
        
        private EvenementsAnimauxRAC[] evenementsAnimauxRACField;
        
        private DonneesElaboreesAnimalRAC[] donneesElaboreesAnimalRACField;
        
        private bool codeSuppressionField;
        
        private bool codeSuppressionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public TypeCodePays CodePays
        {
            get
            {
                return this.codePaysField;
            }
            set
            {
                this.codePaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string NumeroNationalAnimal
        {
            get
            {
                return this.numeroNationalAnimalField;
            }
            set
            {
                this.numeroNationalAnimalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Identite Identite
        {
            get
            {
                return this.identiteField;
            }
            set
            {
                this.identiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvenementsAnimauxRAC", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public EvenementsAnimauxRAC[] EvenementsAnimauxRAC
        {
            get
            {
                return this.evenementsAnimauxRACField;
            }
            set
            {
                this.evenementsAnimauxRACField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DonneesElaboreesAnimalRAC", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public DonneesElaboreesAnimalRAC[] DonneesElaboreesAnimalRAC
        {
            get
            {
                return this.donneesElaboreesAnimalRACField;
            }
            set
            {
                this.donneesElaboreesAnimalRACField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool CodeSuppression
        {
            get
            {
                return this.codeSuppressionField;
            }
            set
            {
                this.codeSuppressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeSuppressionSpecified
        {
            get
            {
                return this.codeSuppressionFieldSpecified;
            }
            set
            {
                this.codeSuppressionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MessageOsBDonneesRAC
    {
        
        private InformationsMessage informationsMessageField;
        
        private BovinRAC[] bovinRACField;
        
        private ReferenceVisitePointage[] referenceVisitePointageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public InformationsMessage InformationsMessage
        {
            get
            {
                return this.informationsMessageField;
            }
            set
            {
                this.informationsMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BovinRAC", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public BovinRAC[] BovinRAC
        {
            get
            {
                return this.bovinRACField;
            }
            set
            {
                this.bovinRACField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceVisitePointage", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public ReferenceVisitePointage[] ReferenceVisitePointage
        {
            get
            {
                return this.referenceVisitePointageField;
            }
            set
            {
                this.referenceVisitePointageField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class OsBGetDonneesRACResponseReponseSpecifique
    {
        
        private MessageOsBDonneesRAC osBDonneesRACField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageOsBDonneesRAC OsBDonneesRAC
        {
            get
            {
                return this.osBDonneesRACField;
            }
            set
            {
                this.osBDonneesRACField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OsBGetDonneesRACRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class OsBGetDonneesRACRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RaceDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public OsBGetDonneesRACRequest()
        {
        }
        
        public OsBGetDonneesRACRequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, string RaceDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.RaceDemande = RaceDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OsBGetDonneesRACResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class OsBGetDonneesRACResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.OsBGetDonneesRACResponseReponseSpecifique ReponseSpecifique;
        
        public OsBGetDonneesRACResponse()
        {
        }
        
        public OsBGetDonneesRACResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.OsBGetDonneesRACResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MdBGetDonneesMalesPublicsResponseReponseSpecifique
    {
        
        private MessageMdBDonneesMalesPublics mdBDonneesMalesPublicsField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageMdBDonneesMalesPublics MdBDonneesMalesPublics
        {
            get
            {
                return this.mdBDonneesMalesPublicsField;
            }
            set
            {
                this.mdBDonneesMalesPublicsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MdBGetDonneesMalesPublicsRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class MdBGetDonneesMalesPublicsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.Organisation OrganismeTiersDemandeur;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute("TaureauReproducteur", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.TaureauReproducteur[] TaureauReproducteur;
        
        public MdBGetDonneesMalesPublicsRequest()
        {
        }
        
        public MdBGetDonneesMalesPublicsRequest(string JetonAuthentification, WsMdBInterfaces.Organisation OrganismeTiersDemandeur, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande, WsMdBInterfaces.TaureauReproducteur[] TaureauReproducteur)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.OrganismeTiersDemandeur = OrganismeTiersDemandeur;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
            this.TaureauReproducteur = TaureauReproducteur;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MdBGetDonneesMalesPublicsResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class MdBGetDonneesMalesPublicsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.MdBGetDonneesMalesPublicsResponseReponseSpecifique ReponseSpecifique;
        
        public MdBGetDonneesMalesPublicsResponse()
        {
        }
        
        public MdBGetDonneesMalesPublicsResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.MdBGetDonneesMalesPublicsResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MdBGetDonneesGenetiquesAnimalesResponseReponseSpecifique
    {
        
        private MessageMdBDonneesGenetiquesAnimales mdBDonneesGenetiquesAnimalesField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageMdBDonneesGenetiquesAnimales MdBDonneesGenetiquesAnimales
        {
            get
            {
                return this.mdBDonneesGenetiquesAnimalesField;
            }
            set
            {
                this.mdBDonneesGenetiquesAnimalesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MdBGetDonneesGenetiquesAnimalesRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class MdBGetDonneesGenetiquesAnimalesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public MdBGetDonneesGenetiquesAnimalesRequest()
        {
        }
        
        public MdBGetDonneesGenetiquesAnimalesRequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MdBGetDonneesGenetiquesAnimalesResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class MdBGetDonneesGenetiquesAnimalesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.MdBGetDonneesGenetiquesAnimalesResponseReponseSpecifique ReponseSpecifique;
        
        public MdBGetDonneesGenetiquesAnimalesResponse()
        {
        }
        
        public MdBGetDonneesGenetiquesAnimalesResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.MdBGetDonneesGenetiquesAnimalesResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class IaBGetDonneesIAResponseReponseSpecifique
    {
        
        private MessageIaBDonneesIA iaBDonneesIAField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageIaBDonneesIA IaBDonneesIA
        {
            get
            {
                return this.iaBDonneesIAField;
            }
            set
            {
                this.iaBDonneesIAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IaBGetDonneesIARequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class IaBGetDonneesIARequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public IaBGetDonneesIARequest()
        {
        }
        
        public IaBGetDonneesIARequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IaBGetDonneesIAResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class IaBGetDonneesIAResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.IaBGetDonneesIAResponseReponseSpecifique ReponseSpecifique;
        
        public IaBGetDonneesIAResponse()
        {
        }
        
        public IaBGetDonneesIAResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.IaBGetDonneesIAResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class TkBGetDonneesTEResponseReponseSpecifique
    {
        
        private MessageTkBDonneesTE tkBDonneesTEField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageTkBDonneesTE TkBDonneesTE
        {
            get
            {
                return this.tkBDonneesTEField;
            }
            set
            {
                this.tkBDonneesTEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TkBGetDonneesTERequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class TkBGetDonneesTERequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public TkBGetDonneesTERequest()
        {
        }
        
        public TkBGetDonneesTERequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TkBGetDonneesTEResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class TkBGetDonneesTEResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.TkBGetDonneesTEResponseReponseSpecifique ReponseSpecifique;
        
        public TkBGetDonneesTEResponse()
        {
        }
        
        public TkBGetDonneesTEResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.TkBGetDonneesTEResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class CpBGetDonneesCPBResponseReponseSpecifique
    {
        
        private MessageCpBDonneesCPB cpBDonneesCPBField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageCpBDonneesCPB CpBDonneesCPB
        {
            get
            {
                return this.cpBDonneesCPBField;
            }
            set
            {
                this.cpBDonneesCPBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CpBGetDonneesCPBRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class CpBGetDonneesCPBRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public CpBGetDonneesCPBRequest()
        {
        }
        
        public CpBGetDonneesCPBRequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CpBGetDonneesCPBResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class CpBGetDonneesCPBResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.CpBGetDonneesCPBResponseReponseSpecifique ReponseSpecifique;
        
        public CpBGetDonneesCPBResponse()
        {
        }
        
        public CpBGetDonneesCPBResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.CpBGetDonneesCPBResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class ClBGetDonneesCLResponseReponseSpecifique
    {
        
        private MessageClBDonneesCL clBDonneesCLField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageClBDonneesCL ClBDonneesCL
        {
            get
            {
                return this.clBDonneesCLField;
            }
            set
            {
                this.clBDonneesCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ClBGetDonneesCLRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class ClBGetDonneesCLRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public ClBGetDonneesCLRequest()
        {
        }
        
        public ClBGetDonneesCLRequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ClBGetDonneesCLResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class ClBGetDonneesCLResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.ClBGetDonneesCLResponseReponseSpecifique ReponseSpecifique;
        
        public ClBGetDonneesCLResponse()
        {
        }
        
        public ClBGetDonneesCLResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.ClBGetDonneesCLResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class VaBGetDonneesCPVResponseReponseSpecifique
    {
        
        private MessageVaBDonneesCPV vaBDonneesCPVField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageVaBDonneesCPV VaBDonneesCPV
        {
            get
            {
                return this.vaBDonneesCPVField;
            }
            set
            {
                this.vaBDonneesCPVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VaBGetDonneesCPVRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class VaBGetDonneesCPVRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public VaBGetDonneesCPVRequest()
        {
        }
        
        public VaBGetDonneesCPVRequest(string JetonAuthentification, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VaBGetDonneesCPVResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class VaBGetDonneesCPVResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.VaBGetDonneesCPVResponseReponseSpecifique ReponseSpecifique;
        
        public VaBGetDonneesCPVResponse()
        {
        }
        
        public VaBGetDonneesCPVResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.VaBGetDonneesCPVResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.idele.fr/XML/Schema")]
    public partial class MdBGetDonneesOrganismeTiersResponseReponseSpecifique
    {
        
        private MessageMdBDonneesOrganismeTiers mdBDonneesOrganismeTiersField;
        
        private byte[] messageZipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public MessageMdBDonneesOrganismeTiers MdBDonneesOrganismeTiers
        {
            get
            {
                return this.mdBDonneesOrganismeTiersField;
            }
            set
            {
                this.mdBDonneesOrganismeTiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] MessageZip
        {
            get
            {
                return this.messageZipField;
            }
            set
            {
                this.messageZipField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MdBGetDonneesOrganismeTiersRequest", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class MdBGetDonneesOrganismeTiersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JetonAuthentification;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.Organisation OrganismeTiersDemandeur;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeIdentifiantExploitation Exploitation;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateDebutDemande;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DateFinDemande;
        
        public MdBGetDonneesOrganismeTiersRequest()
        {
        }
        
        public MdBGetDonneesOrganismeTiersRequest(string JetonAuthentification, WsMdBInterfaces.Organisation OrganismeTiersDemandeur, WsMdBInterfaces.typeIdentifiantExploitation Exploitation, System.DateTime DateDebutDemande, System.DateTime DateFinDemande)
        {
            this.JetonAuthentification = JetonAuthentification;
            this.OrganismeTiersDemandeur = OrganismeTiersDemandeur;
            this.Exploitation = Exploitation;
            this.DateDebutDemande = DateDebutDemande;
            this.DateFinDemande = DateFinDemande;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MdBGetDonneesOrganismeTiersResponse", WrapperNamespace="http://www.idele.fr/XML/Schema", IsWrapped=true)]
    public partial class MdBGetDonneesOrganismeTiersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.typeReponse ReponseStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.idele.fr/XML/Schema", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WsMdBInterfaces.MdBGetDonneesOrganismeTiersResponseReponseSpecifique ReponseSpecifique;
        
        public MdBGetDonneesOrganismeTiersResponse()
        {
        }
        
        public MdBGetDonneesOrganismeTiersResponse(WsMdBInterfaces.typeReponse ReponseStandard, WsMdBInterfaces.MdBGetDonneesOrganismeTiersResponseReponseSpecifique ReponseSpecifique)
        {
            this.ReponseStandard = ReponseStandard;
            this.ReponseSpecifique = ReponseSpecifique;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface wsMdBInterfaceChannel : WsMdBInterfaces.wsMdBInterface, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class wsMdBInterfaceClient : System.ServiceModel.ClientBase<WsMdBInterfaces.wsMdBInterface>, WsMdBInterfaces.wsMdBInterface
    {
        
    /// <summary>
    /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
    /// </summary>
    /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
    /// <param name="clientCredentials">Informations d'identification du client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public wsMdBInterfaceClient() : 
                base(wsMdBInterfaceClient.GetDefaultBinding(), wsMdBInterfaceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.wsMdBPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public wsMdBInterfaceClient(EndpointConfiguration endpointConfiguration) : 
                base(wsMdBInterfaceClient.GetBindingForEndpoint(endpointConfiguration), wsMdBInterfaceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public wsMdBInterfaceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(wsMdBInterfaceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public wsMdBInterfaceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(wsMdBInterfaceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public wsMdBInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.OsBGetDonneesRACResponse> OsBGetDonneesRACAsync(WsMdBInterfaces.OsBGetDonneesRACRequest request)
        {
            return base.Channel.OsBGetDonneesRACAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.MdBGetDonneesMalesPublicsResponse> MdBGetDonneesMalesPublicsAsync(WsMdBInterfaces.MdBGetDonneesMalesPublicsRequest request)
        {
            return base.Channel.MdBGetDonneesMalesPublicsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.MdBGetDonneesGenetiquesAnimalesResponse> MdBGetDonneesGenetiquesAnimalesAsync(WsMdBInterfaces.MdBGetDonneesGenetiquesAnimalesRequest request)
        {
            return base.Channel.MdBGetDonneesGenetiquesAnimalesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.IaBGetDonneesIAResponse> IaBGetDonneesIAAsync(WsMdBInterfaces.IaBGetDonneesIARequest request)
        {
            return base.Channel.IaBGetDonneesIAAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.TkBGetDonneesTEResponse> TkBGetDonneesTEAsync(WsMdBInterfaces.TkBGetDonneesTERequest request)
        {
            return base.Channel.TkBGetDonneesTEAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.CpBGetDonneesCPBResponse> CpBGetDonneesCPBAsync(WsMdBInterfaces.CpBGetDonneesCPBRequest request)
        {
            return base.Channel.CpBGetDonneesCPBAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.ClBGetDonneesCLResponse> ClBGetDonneesCLAsync(WsMdBInterfaces.ClBGetDonneesCLRequest request)
        {
            return base.Channel.ClBGetDonneesCLAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.VaBGetDonneesCPVResponse> VaBGetDonneesCPVAsync(WsMdBInterfaces.VaBGetDonneesCPVRequest request)
        {
            return base.Channel.VaBGetDonneesCPVAsync(request);
        }
        
        public System.Threading.Tasks.Task<WsMdBInterfaces.MdBGetDonneesOrganismeTiersResponse> MdBGetDonneesOrganismeTiersAsync(WsMdBInterfaces.MdBGetDonneesOrganismeTiersRequest request)
        {
            return base.Channel.MdBGetDonneesOrganismeTiersAsync(request);
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
            if ((endpointConfiguration == EndpointConfiguration.wsMdBPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.wsMdBPort))
            {
                return new System.ServiceModel.EndpointAddress("https://wsppabr-edel.equade.fr/wsEdel/WsMdBInterface");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return wsMdBInterfaceClient.GetBindingForEndpoint(EndpointConfiguration.wsMdBPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return wsMdBInterfaceClient.GetEndpointAddress(EndpointConfiguration.wsMdBPort);
        }
        
        public enum EndpointConfiguration
        {
            
            wsMdBPort,
        }
    }
}
