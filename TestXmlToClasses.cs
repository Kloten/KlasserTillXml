using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserTillXml
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class paxml
    {

        private paxmlSaldo[] saldonField;

        private paxmlLonebesked[] loneutbetalningField;

        private paxmlPerson[] personalField;

        private paxmlSchema[] schematransaktionerField;

        private paxmlLonetrans[] lonetransaktionerField;

        private paxmlTidtransaktioner tidtransaktionerField;

        private paxmlResetransaktioner resetransaktionerField;

        private paxmlKod[] koderField;

        private paxmlResultatenhet[] resultatenheterField;

        private paxmlDimension[] dimensionerField;

        private paxmlHeader headerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("saldo", IsNullable = false)]
        public paxmlSaldo[] saldon
        {
            get
            {
                return this.saldonField;
            }
            set
            {
                this.saldonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("lonebesked", IsNullable = false)]
        public paxmlLonebesked[] loneutbetalning
        {
            get
            {
                return this.loneutbetalningField;
            }
            set
            {
                this.loneutbetalningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("person", IsNullable = false)]
        public paxmlPerson[] personal
        {
            get
            {
                return this.personalField;
            }
            set
            {
                this.personalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("schema", IsNullable = false)]
        public paxmlSchema[] schematransaktioner
        {
            get
            {
                return this.schematransaktionerField;
            }
            set
            {
                this.schematransaktionerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("lonetrans", IsNullable = false)]
        public paxmlLonetrans[] lonetransaktioner
        {
            get
            {
                return this.lonetransaktionerField;
            }
            set
            {
                this.lonetransaktionerField = value;
            }
        }

        /// <remarks/>
        public paxmlTidtransaktioner tidtransaktioner
        {
            get
            {
                return this.tidtransaktionerField;
            }
            set
            {
                this.tidtransaktionerField = value;
            }
        }

        /// <remarks/>
        public paxmlResetransaktioner resetransaktioner
        {
            get
            {
                return this.resetransaktionerField;
            }
            set
            {
                this.resetransaktionerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("kod", IsNullable = false)]
        public paxmlKod[] koder
        {
            get
            {
                return this.koderField;
            }
            set
            {
                this.koderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resultatenhet", IsNullable = false)]
        public paxmlResultatenhet[] resultatenheter
        {
            get
            {
                return this.resultatenheterField;
            }
            set
            {
                this.resultatenheterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("dimension", IsNullable = false)]
        public paxmlDimension[] dimensioner
        {
            get
            {
                return this.dimensionerField;
            }
            set
            {
                this.dimensionerField = value;
            }
        }

        /// <remarks/>
        public paxmlHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlSaldo
    {

        private string infoField;

        private string semlonutbField;

        private string semlontotField;

        private string semspautbField;

        private string semspatotField;

        private string semforutbField;

        private string semfortotField;

        private string semobeutbField;

        private string semobetotField;

        private string sembetutbField;

        private string sembettotField;

        private string tidbankbelField;

        private string tidbanktimField;

        private string kompsaldoField;

        private string flexsaldoField;

        private string acknettolonField;

        private string ackprelskattField;

        private string ackbruttolonField;

        private System.DateTime datumField;

        private string anstidField;

        private string persnrField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semlonutb
        {
            get
            {
                return this.semlonutbField;
            }
            set
            {
                this.semlonutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semlontot
        {
            get
            {
                return this.semlontotField;
            }
            set
            {
                this.semlontotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semspautb
        {
            get
            {
                return this.semspautbField;
            }
            set
            {
                this.semspautbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semspatot
        {
            get
            {
                return this.semspatotField;
            }
            set
            {
                this.semspatotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semforutb
        {
            get
            {
                return this.semforutbField;
            }
            set
            {
                this.semforutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semfortot
        {
            get
            {
                return this.semfortotField;
            }
            set
            {
                this.semfortotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semobeutb
        {
            get
            {
                return this.semobeutbField;
            }
            set
            {
                this.semobeutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semobetot
        {
            get
            {
                return this.semobetotField;
            }
            set
            {
                this.semobetotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sembetutb
        {
            get
            {
                return this.sembetutbField;
            }
            set
            {
                this.sembetutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sembettot
        {
            get
            {
                return this.sembettotField;
            }
            set
            {
                this.sembettotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string tidbankbel
        {
            get
            {
                return this.tidbankbelField;
            }
            set
            {
                this.tidbankbelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string tidbanktim
        {
            get
            {
                return this.tidbanktimField;
            }
            set
            {
                this.tidbanktimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string kompsaldo
        {
            get
            {
                return this.kompsaldoField;
            }
            set
            {
                this.kompsaldoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string flexsaldo
        {
            get
            {
                return this.flexsaldoField;
            }
            set
            {
                this.flexsaldoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string acknettolon
        {
            get
            {
                return this.acknettolonField;
            }
            set
            {
                this.acknettolonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ackprelskatt
        {
            get
            {
                return this.ackprelskattField;
            }
            set
            {
                this.ackprelskattField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ackbruttolon
        {
            get
            {
                return this.ackbruttolonField;
            }
            set
            {
                this.ackbruttolonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebesked
    {

        private string infoField;

        private paxmlLonebeskedTransaktion[] konteringField;

        private string semlonutbField;

        private string semlontotField;

        private string semspautbField;

        private string semspatotField;

        private string semforutbField;

        private string semfortotField;

        private string semobeutbField;

        private string semobetotField;

        private string sembetutbField;

        private string sembettotField;

        private string tidbankbelField;

        private string tidbanktimField;

        private string kompsaldoField;

        private string flexsaldoField;

        private string acknettolonField;

        private string ackprelskattField;

        private string ackbruttolonField;

        private paxmlLonebeskedLonrad[] loneraderField;

        private string arbavgiftbelField;

        private string arbavgiftprcField;

        private string utbetaltField;

        private string extraskattField;

        private string kapitalskattField;

        private string engangsskattField;

        private string tabellskattField;

        private int skattekolumnField;

        private string jamkningbelField;

        private string jamkningprcField;

        private int skattetabellField;

        private string skattprocentField;

        private string bankkontoField;

        private string clearingnrField;

        private string landField;

        private string ortField;

        private string postnrField;

        private string postadressField;

        private string extraadressField;

        private string efternamnField;

        private string fornamnField;

        private System.DateTime betaldatumField;

        private string periodtextField;

        private string periodidField;

        private string anstidField;

        private string persnrField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("transaktion", IsNullable = false)]
        public paxmlLonebeskedTransaktion[] kontering
        {
            get
            {
                return this.konteringField;
            }
            set
            {
                this.konteringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semlonutb
        {
            get
            {
                return this.semlonutbField;
            }
            set
            {
                this.semlonutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semlontot
        {
            get
            {
                return this.semlontotField;
            }
            set
            {
                this.semlontotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semspautb
        {
            get
            {
                return this.semspautbField;
            }
            set
            {
                this.semspautbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semspatot
        {
            get
            {
                return this.semspatotField;
            }
            set
            {
                this.semspatotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semforutb
        {
            get
            {
                return this.semforutbField;
            }
            set
            {
                this.semforutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semfortot
        {
            get
            {
                return this.semfortotField;
            }
            set
            {
                this.semfortotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semobeutb
        {
            get
            {
                return this.semobeutbField;
            }
            set
            {
                this.semobeutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semobetot
        {
            get
            {
                return this.semobetotField;
            }
            set
            {
                this.semobetotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sembetutb
        {
            get
            {
                return this.sembetutbField;
            }
            set
            {
                this.sembetutbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sembettot
        {
            get
            {
                return this.sembettotField;
            }
            set
            {
                this.sembettotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string tidbankbel
        {
            get
            {
                return this.tidbankbelField;
            }
            set
            {
                this.tidbankbelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string tidbanktim
        {
            get
            {
                return this.tidbanktimField;
            }
            set
            {
                this.tidbanktimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string kompsaldo
        {
            get
            {
                return this.kompsaldoField;
            }
            set
            {
                this.kompsaldoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string flexsaldo
        {
            get
            {
                return this.flexsaldoField;
            }
            set
            {
                this.flexsaldoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string acknettolon
        {
            get
            {
                return this.acknettolonField;
            }
            set
            {
                this.acknettolonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ackprelskatt
        {
            get
            {
                return this.ackprelskattField;
            }
            set
            {
                this.ackprelskattField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ackbruttolon
        {
            get
            {
                return this.ackbruttolonField;
            }
            set
            {
                this.ackbruttolonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("lonrad", IsNullable = false)]
        public paxmlLonebeskedLonrad[] lonerader
        {
            get
            {
                return this.loneraderField;
            }
            set
            {
                this.loneraderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string arbavgiftbel
        {
            get
            {
                return this.arbavgiftbelField;
            }
            set
            {
                this.arbavgiftbelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string arbavgiftprc
        {
            get
            {
                return this.arbavgiftprcField;
            }
            set
            {
                this.arbavgiftprcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string utbetalt
        {
            get
            {
                return this.utbetaltField;
            }
            set
            {
                this.utbetaltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string extraskatt
        {
            get
            {
                return this.extraskattField;
            }
            set
            {
                this.extraskattField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string kapitalskatt
        {
            get
            {
                return this.kapitalskattField;
            }
            set
            {
                this.kapitalskattField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string engangsskatt
        {
            get
            {
                return this.engangsskattField;
            }
            set
            {
                this.engangsskattField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string tabellskatt
        {
            get
            {
                return this.tabellskattField;
            }
            set
            {
                this.tabellskattField = value;
            }
        }

        /// <remarks/>
        public int skattekolumn
        {
            get
            {
                return this.skattekolumnField;
            }
            set
            {
                this.skattekolumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string jamkningbel
        {
            get
            {
                return this.jamkningbelField;
            }
            set
            {
                this.jamkningbelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string jamkningprc
        {
            get
            {
                return this.jamkningprcField;
            }
            set
            {
                this.jamkningprcField = value;
            }
        }

        /// <remarks/>
        public int skattetabell
        {
            get
            {
                return this.skattetabellField;
            }
            set
            {
                this.skattetabellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string skattprocent
        {
            get
            {
                return this.skattprocentField;
            }
            set
            {
                this.skattprocentField = value;
            }
        }

        /// <remarks/>
        public string bankkonto
        {
            get
            {
                return this.bankkontoField;
            }
            set
            {
                this.bankkontoField = value;
            }
        }

        /// <remarks/>
        public string clearingnr
        {
            get
            {
                return this.clearingnrField;
            }
            set
            {
                this.clearingnrField = value;
            }
        }

        /// <remarks/>
        public string land
        {
            get
            {
                return this.landField;
            }
            set
            {
                this.landField = value;
            }
        }

        /// <remarks/>
        public string ort
        {
            get
            {
                return this.ortField;
            }
            set
            {
                this.ortField = value;
            }
        }

        /// <remarks/>
        public string postnr
        {
            get
            {
                return this.postnrField;
            }
            set
            {
                this.postnrField = value;
            }
        }

        /// <remarks/>
        public string postadress
        {
            get
            {
                return this.postadressField;
            }
            set
            {
                this.postadressField = value;
            }
        }

        /// <remarks/>
        public string extraadress
        {
            get
            {
                return this.extraadressField;
            }
            set
            {
                this.extraadressField = value;
            }
        }

        /// <remarks/>
        public string efternamn
        {
            get
            {
                return this.efternamnField;
            }
            set
            {
                this.efternamnField = value;
            }
        }

        /// <remarks/>
        public string fornamn
        {
            get
            {
                return this.fornamnField;
            }
            set
            {
                this.fornamnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime betaldatum
        {
            get
            {
                return this.betaldatumField;
            }
            set
            {
                this.betaldatumField = value;
            }
        }

        /// <remarks/>
        public string periodtext
        {
            get
            {
                return this.periodtextField;
            }
            set
            {
                this.periodtextField = value;
            }
        }

        /// <remarks/>
        public string periodid
        {
            get
            {
                return this.periodidField;
            }
            set
            {
                this.periodidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebeskedTransaktion
    {

        private paxmlLonebeskedTransaktionResenhet[] resenheterField;

        private paxmlLonebeskedTransaktionKundnr kundnrField;

        private string kontonrField;

        private decimal beloppField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resenhet", IsNullable = false)]
        public paxmlLonebeskedTransaktionResenhet[] resenheter
        {
            get
            {
                return this.resenheterField;
            }
            set
            {
                this.resenheterField = value;
            }
        }

        /// <remarks/>
        public paxmlLonebeskedTransaktionKundnr kundnr
        {
            get
            {
                return this.kundnrField;
            }
            set
            {
                this.kundnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kontonr
        {
            get
            {
                return this.kontonrField;
            }
            set
            {
                this.kontonrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal belopp
        {
            get
            {
                return this.beloppField;
            }
            set
            {
                this.beloppField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebeskedTransaktionResenhet
    {

        private byte dimField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebeskedTransaktionKundnr
    {

        private string infoField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebeskedLonrad
    {

        private string infoField;

        private string kontrolluppgiftField;

        private string statistikkodField;

        private paxmlLonebeskedLonradResenhet[] resenheterField;

        private paxmlLonebeskedLonradKundnr kundnrField;

        private string kontonrField;

        private bool regionalField;

        private decimal avgiftprocentField;

        private string avgifttypField;

        private decimal skattprocentField;

        private string skattetypField;

        private string lonetypField;

        private decimal beloppField;

        private decimal aprisField;

        private decimal antalField;

        private string enhetField;

        private decimal dagarField;

        private decimal arbetsdagarField;

        private decimal timmarField;

        private System.DateTime datumtomField;

        private System.DateTime datumfromField;

        private string kommentarField;

        private string benamningField;

        private string fontField;

        private string lonartField;

        private int radnrField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        public string kontrolluppgift
        {
            get
            {
                return this.kontrolluppgiftField;
            }
            set
            {
                this.kontrolluppgiftField = value;
            }
        }

        /// <remarks/>
        public string statistikkod
        {
            get
            {
                return this.statistikkodField;
            }
            set
            {
                this.statistikkodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resenhet", IsNullable = false)]
        public paxmlLonebeskedLonradResenhet[] resenheter
        {
            get
            {
                return this.resenheterField;
            }
            set
            {
                this.resenheterField = value;
            }
        }

        /// <remarks/>
        public paxmlLonebeskedLonradKundnr kundnr
        {
            get
            {
                return this.kundnrField;
            }
            set
            {
                this.kundnrField = value;
            }
        }

        /// <remarks/>
        public string kontonr
        {
            get
            {
                return this.kontonrField;
            }
            set
            {
                this.kontonrField = value;
            }
        }

        /// <remarks/>
        public bool regional
        {
            get
            {
                return this.regionalField;
            }
            set
            {
                this.regionalField = value;
            }
        }

        /// <remarks/>
        public decimal avgiftprocent
        {
            get
            {
                return this.avgiftprocentField;
            }
            set
            {
                this.avgiftprocentField = value;
            }
        }

        /// <remarks/>
        public string avgifttyp
        {
            get
            {
                return this.avgifttypField;
            }
            set
            {
                this.avgifttypField = value;
            }
        }

        /// <remarks/>
        public decimal skattprocent
        {
            get
            {
                return this.skattprocentField;
            }
            set
            {
                this.skattprocentField = value;
            }
        }

        /// <remarks/>
        public string skattetyp
        {
            get
            {
                return this.skattetypField;
            }
            set
            {
                this.skattetypField = value;
            }
        }

        /// <remarks/>
        public string lonetyp
        {
            get
            {
                return this.lonetypField;
            }
            set
            {
                this.lonetypField = value;
            }
        }

        /// <remarks/>
        public decimal belopp
        {
            get
            {
                return this.beloppField;
            }
            set
            {
                this.beloppField = value;
            }
        }

        /// <remarks/>
        public decimal apris
        {
            get
            {
                return this.aprisField;
            }
            set
            {
                this.aprisField = value;
            }
        }

        /// <remarks/>
        public decimal antal
        {
            get
            {
                return this.antalField;
            }
            set
            {
                this.antalField = value;
            }
        }

        /// <remarks/>
        public string enhet
        {
            get
            {
                return this.enhetField;
            }
            set
            {
                this.enhetField = value;
            }
        }

        /// <remarks/>
        public decimal dagar
        {
            get
            {
                return this.dagarField;
            }
            set
            {
                this.dagarField = value;
            }
        }

        /// <remarks/>
        public decimal arbetsdagar
        {
            get
            {
                return this.arbetsdagarField;
            }
            set
            {
                this.arbetsdagarField = value;
            }
        }

        /// <remarks/>
        public decimal timmar
        {
            get
            {
                return this.timmarField;
            }
            set
            {
                this.timmarField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datumtom
        {
            get
            {
                return this.datumtomField;
            }
            set
            {
                this.datumtomField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datumfrom
        {
            get
            {
                return this.datumfromField;
            }
            set
            {
                this.datumfromField = value;
            }
        }

        /// <remarks/>
        public string kommentar
        {
            get
            {
                return this.kommentarField;
            }
            set
            {
                this.kommentarField = value;
            }
        }

        /// <remarks/>
        public string benamning
        {
            get
            {
                return this.benamningField;
            }
            set
            {
                this.benamningField = value;
            }
        }

        /// <remarks/>
        public string font
        {
            get
            {
                return this.fontField;
            }
            set
            {
                this.fontField = value;
            }
        }

        /// <remarks/>
        public string lonart
        {
            get
            {
                return this.lonartField;
            }
            set
            {
                this.lonartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int radnr
        {
            get
            {
                return this.radnrField;
            }
            set
            {
                this.radnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebeskedLonradResenhet
    {

        private byte dimField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonebeskedLonradKundnr
    {

        private string infoField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPerson
    {

        private string infoField;

        private paxmlPersonResenhet[] resenheterField;

        private paxmlPersonLoneutmatning loneutmatningField;

        private paxmlPersonSkattejamkning skattejamkningField;

        private int skattekolumnField;

        private string skattetabellField;

        private string semesterdagarField;

        private paxmlPersonSysgrad sysgradField;

        private paxmlPersonText[] persontexterField;

        private paxmlPersonBelopp[] personbeloppField;

        private paxmlPersonManlon manlonField;

        private paxmlPersonTimlon timlonField;

        private bool innevarandeField;

        private string lonformField;

        private System.DateTime avgdatumField;

        private System.DateTime anstdatumField;

        private string bankkontoField;

        private string bankclearingField;

        private string semesteravtalField;

        private string anstformField;

        private string befattningskodField;

        private string befattningField;

        private string kategoriField;

        private string personaltypField;

        private string eposthemField;

        private string epostarbField;

        private string arbetstelefonField;

        private string hemtelefonField;

        private string mobiltelefonField;

        private string landField;

        private string ortField;

        private string postnrField;

        private string postadressField;

        private string extraadressField;

        private string efternamnField;

        private string fornamnField;

        private string anstidField;

        private string persnrField;

        private bool deleteField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resenhet", IsNullable = false)]
        public paxmlPersonResenhet[] resenheter
        {
            get
            {
                return this.resenheterField;
            }
            set
            {
                this.resenheterField = value;
            }
        }

        /// <remarks/>
        public paxmlPersonLoneutmatning loneutmatning
        {
            get
            {
                return this.loneutmatningField;
            }
            set
            {
                this.loneutmatningField = value;
            }
        }

        /// <remarks/>
        public paxmlPersonSkattejamkning skattejamkning
        {
            get
            {
                return this.skattejamkningField;
            }
            set
            {
                this.skattejamkningField = value;
            }
        }

        /// <remarks/>
        public int skattekolumn
        {
            get
            {
                return this.skattekolumnField;
            }
            set
            {
                this.skattekolumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string skattetabell
        {
            get
            {
                return this.skattetabellField;
            }
            set
            {
                this.skattetabellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string semesterdagar
        {
            get
            {
                return this.semesterdagarField;
            }
            set
            {
                this.semesterdagarField = value;
            }
        }

        /// <remarks/>
        public paxmlPersonSysgrad sysgrad
        {
            get
            {
                return this.sysgradField;
            }
            set
            {
                this.sysgradField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("text", IsNullable = false)]
        public paxmlPersonText[] persontexter
        {
            get
            {
                return this.persontexterField;
            }
            set
            {
                this.persontexterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("belopp", IsNullable = false)]
        public paxmlPersonBelopp[] personbelopp
        {
            get
            {
                return this.personbeloppField;
            }
            set
            {
                this.personbeloppField = value;
            }
        }

        /// <remarks/>
        public paxmlPersonManlon manlon
        {
            get
            {
                return this.manlonField;
            }
            set
            {
                this.manlonField = value;
            }
        }

        /// <remarks/>
        public paxmlPersonTimlon timlon
        {
            get
            {
                return this.timlonField;
            }
            set
            {
                this.timlonField = value;
            }
        }

        /// <remarks/>
        public bool innevarande
        {
            get
            {
                return this.innevarandeField;
            }
            set
            {
                this.innevarandeField = value;
            }
        }

        /// <remarks/>
        public string lonform
        {
            get
            {
                return this.lonformField;
            }
            set
            {
                this.lonformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime avgdatum
        {
            get
            {
                return this.avgdatumField;
            }
            set
            {
                this.avgdatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime anstdatum
        {
            get
            {
                return this.anstdatumField;
            }
            set
            {
                this.anstdatumField = value;
            }
        }

        /// <remarks/>
        public string bankkonto
        {
            get
            {
                return this.bankkontoField;
            }
            set
            {
                this.bankkontoField = value;
            }
        }

        /// <remarks/>
        public string bankclearing
        {
            get
            {
                return this.bankclearingField;
            }
            set
            {
                this.bankclearingField = value;
            }
        }

        /// <remarks/>
        public string semesteravtal
        {
            get
            {
                return this.semesteravtalField;
            }
            set
            {
                this.semesteravtalField = value;
            }
        }

        /// <remarks/>
        public string anstform
        {
            get
            {
                return this.anstformField;
            }
            set
            {
                this.anstformField = value;
            }
        }

        /// <remarks/>
        public string befattningskod
        {
            get
            {
                return this.befattningskodField;
            }
            set
            {
                this.befattningskodField = value;
            }
        }

        /// <remarks/>
        public string befattning
        {
            get
            {
                return this.befattningField;
            }
            set
            {
                this.befattningField = value;
            }
        }

        /// <remarks/>
        public string kategori
        {
            get
            {
                return this.kategoriField;
            }
            set
            {
                this.kategoriField = value;
            }
        }

        /// <remarks/>
        public string personaltyp
        {
            get
            {
                return this.personaltypField;
            }
            set
            {
                this.personaltypField = value;
            }
        }

        /// <remarks/>
        public string eposthem
        {
            get
            {
                return this.eposthemField;
            }
            set
            {
                this.eposthemField = value;
            }
        }

        /// <remarks/>
        public string epostarb
        {
            get
            {
                return this.epostarbField;
            }
            set
            {
                this.epostarbField = value;
            }
        }

        /// <remarks/>
        public string arbetstelefon
        {
            get
            {
                return this.arbetstelefonField;
            }
            set
            {
                this.arbetstelefonField = value;
            }
        }

        /// <remarks/>
        public string hemtelefon
        {
            get
            {
                return this.hemtelefonField;
            }
            set
            {
                this.hemtelefonField = value;
            }
        }

        /// <remarks/>
        public string mobiltelefon
        {
            get
            {
                return this.mobiltelefonField;
            }
            set
            {
                this.mobiltelefonField = value;
            }
        }

        /// <remarks/>
        public string land
        {
            get
            {
                return this.landField;
            }
            set
            {
                this.landField = value;
            }
        }

        /// <remarks/>
        public string ort
        {
            get
            {
                return this.ortField;
            }
            set
            {
                this.ortField = value;
            }
        }

        /// <remarks/>
        public string postnr
        {
            get
            {
                return this.postnrField;
            }
            set
            {
                this.postnrField = value;
            }
        }

        /// <remarks/>
        public string postadress
        {
            get
            {
                return this.postadressField;
            }
            set
            {
                this.postadressField = value;
            }
        }

        /// <remarks/>
        public string extraadress
        {
            get
            {
                return this.extraadressField;
            }
            set
            {
                this.extraadressField = value;
            }
        }

        /// <remarks/>
        public string efternamn
        {
            get
            {
                return this.efternamnField;
            }
            set
            {
                this.efternamnField = value;
            }
        }

        /// <remarks/>
        public string fornamn
        {
            get
            {
                return this.fornamnField;
            }
            set
            {
                this.fornamnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonResenhet
    {

        private byte dimField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonLoneutmatning
    {

        private string beloppField;

        private string forbehallField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string belopp
        {
            get
            {
                return this.beloppField;
            }
            set
            {
                this.beloppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string forbehall
        {
            get
            {
                return this.forbehallField;
            }
            set
            {
                this.forbehallField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonSkattejamkning
    {

        private int procentField;

        private string beloppField;

        private string maxbeloppField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int procent
        {
            get
            {
                return this.procentField;
            }
            set
            {
                this.procentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string belopp
        {
            get
            {
                return this.beloppField;
            }
            set
            {
                this.beloppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string maxbelopp
        {
            get
            {
                return this.maxbeloppField;
            }
            set
            {
                this.maxbeloppField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonSysgrad
    {

        private System.DateTime datumField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonText
    {

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonBelopp
    {

        private string idField;

        private System.DateTime datumField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonManlon
    {

        private System.DateTime datumField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlPersonTimlon
    {

        private System.DateTime datumField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlSchema
    {

        private paxmlSchemaDag[] dagField;

        private string anstidField;

        private string persnrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dag")]
        public paxmlSchemaDag[] dag
        {
            get
            {
                return this.dagField;
            }
            set
            {
                this.dagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlSchemaDag
    {

        private System.DateTime datumField;

        private System.DateTime starttidField;

        private System.DateTime sluttidField;

        private decimal timmarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime starttid
        {
            get
            {
                return this.starttidField;
            }
            set
            {
                this.starttidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime sluttid
        {
            get
            {
                return this.sluttidField;
            }
            set
            {
                this.sluttidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal timmar
        {
            get
            {
                return this.timmarField;
            }
            set
            {
                this.timmarField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonetrans
    {

        private string infoField;

        private paxmlLonetransResenhet[] resenheterField;

        private paxmlLonetransKundnr kundnrField;

        private string kontonrField;

        private string samlingsidField;

        private string momsField;

        private string varugruppField;

        private string beloppField;

        private string aprisField;

        private string antalField;

        private System.DateTime datumtomField;

        private System.DateTime datumfromField;

        private System.DateTime datumField;

        private string kommentarField;

        private string benamningField;

        private string lonartField;

        private string lonkodField;

        private int postidField;

        private string anstidField;

        private string persnrField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resenhet", IsNullable = false)]
        public paxmlLonetransResenhet[] resenheter
        {
            get
            {
                return this.resenheterField;
            }
            set
            {
                this.resenheterField = value;
            }
        }

        /// <remarks/>
        public paxmlLonetransKundnr kundnr
        {
            get
            {
                return this.kundnrField;
            }
            set
            {
                this.kundnrField = value;
            }
        }

        /// <remarks/>
        public string kontonr
        {
            get
            {
                return this.kontonrField;
            }
            set
            {
                this.kontonrField = value;
            }
        }

        /// <remarks/>
        public string samlingsid
        {
            get
            {
                return this.samlingsidField;
            }
            set
            {
                this.samlingsidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string moms
        {
            get
            {
                return this.momsField;
            }
            set
            {
                this.momsField = value;
            }
        }

        /// <remarks/>
        public string varugrupp
        {
            get
            {
                return this.varugruppField;
            }
            set
            {
                this.varugruppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string belopp
        {
            get
            {
                return this.beloppField;
            }
            set
            {
                this.beloppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string apris
        {
            get
            {
                return this.aprisField;
            }
            set
            {
                this.aprisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string antal
        {
            get
            {
                return this.antalField;
            }
            set
            {
                this.antalField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datumtom
        {
            get
            {
                return this.datumtomField;
            }
            set
            {
                this.datumtomField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datumfrom
        {
            get
            {
                return this.datumfromField;
            }
            set
            {
                this.datumfromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        public string kommentar
        {
            get
            {
                return this.kommentarField;
            }
            set
            {
                this.kommentarField = value;
            }
        }

        /// <remarks/>
        public string benamning
        {
            get
            {
                return this.benamningField;
            }
            set
            {
                this.benamningField = value;
            }
        }

        /// <remarks/>
        public string lonart
        {
            get
            {
                return this.lonartField;
            }
            set
            {
                this.lonartField = value;
            }
        }

        /// <remarks/>
        public string lonkod
        {
            get
            {
                return this.lonkodField;
            }
            set
            {
                this.lonkodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int postid
        {
            get
            {
                return this.postidField;
            }
            set
            {
                this.postidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonetransResenhet
    {

        private byte dimField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlLonetransKundnr
    {

        private string infoField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlTidtransaktioner
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attesterat", typeof(paxmlTidtransaktionerAttesterat))]
        [System.Xml.Serialization.XmlElementAttribute("klar", typeof(paxmlTidtransaktionerKlar))]
        [System.Xml.Serialization.XmlElementAttribute("tidtrans", typeof(paxmlTidtransaktionerTidtrans))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlTidtransaktionerAttesterat
    {

        private int postidField;

        private string anstidField;

        private string persnrField;

        private System.DateTime datumField;

        private System.DateTime datumfromField;

        private System.DateTime datumtomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int postid
        {
            get
            {
                return this.postidField;
            }
            set
            {
                this.postidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datumfrom
        {
            get
            {
                return this.datumfromField;
            }
            set
            {
                this.datumfromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datumtom
        {
            get
            {
                return this.datumtomField;
            }
            set
            {
                this.datumtomField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlTidtransaktionerKlar
    {

        private int postidField;

        private string anstidField;

        private string persnrField;

        private System.DateTime datumField;

        private System.DateTime datumfromField;

        private System.DateTime datumtomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int postid
        {
            get
            {
                return this.postidField;
            }
            set
            {
                this.postidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datumfrom
        {
            get
            {
                return this.datumfromField;
            }
            set
            {
                this.datumfromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datumtom
        {
            get
            {
                return this.datumtomField;
            }
            set
            {
                this.datumtomField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlTidtransaktionerTidtrans
    {

        private string infoField;

        private paxmlTidtransaktionerTidtransResenhet[] resenheterField;

        private paxmlTidtransaktionerTidtransKundnr kundnrField;

        private string kontonrField;

        private bool semgrundField;

        private string samlingsidField;

        private string barnField;

        private decimal omfattningField;

        private string timmarField;

        private System.DateTime sluttidField;

        private System.DateTime starttidField;

        private System.DateTime datumtomField;

        private System.DateTime datumfromField;

        private System.DateTime datumField;

        private string tidkodField;

        private int postidField;

        private string anstidField;

        private string persnrField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resenhet", IsNullable = false)]
        public paxmlTidtransaktionerTidtransResenhet[] resenheter
        {
            get
            {
                return this.resenheterField;
            }
            set
            {
                this.resenheterField = value;
            }
        }

        /// <remarks/>
        public paxmlTidtransaktionerTidtransKundnr kundnr
        {
            get
            {
                return this.kundnrField;
            }
            set
            {
                this.kundnrField = value;
            }
        }

        /// <remarks/>
        public string kontonr
        {
            get
            {
                return this.kontonrField;
            }
            set
            {
                this.kontonrField = value;
            }
        }

        /// <remarks/>
        public bool semgrund
        {
            get
            {
                return this.semgrundField;
            }
            set
            {
                this.semgrundField = value;
            }
        }

        /// <remarks/>
        public string samlingsid
        {
            get
            {
                return this.samlingsidField;
            }
            set
            {
                this.samlingsidField = value;
            }
        }

        /// <remarks/>
        public string barn
        {
            get
            {
                return this.barnField;
            }
            set
            {
                this.barnField = value;
            }
        }

        /// <remarks/>
        public decimal omfattning
        {
            get
            {
                return this.omfattningField;
            }
            set
            {
                this.omfattningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string timmar
        {
            get
            {
                return this.timmarField;
            }
            set
            {
                this.timmarField = value;
            }
        }

        /// <remarks/>
        public System.DateTime sluttid
        {
            get
            {
                return this.sluttidField;
            }
            set
            {
                this.sluttidField = value;
            }
        }

        /// <remarks/>
        public System.DateTime starttid
        {
            get
            {
                return this.starttidField;
            }
            set
            {
                this.starttidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumtom
        {
            get
            {
                return this.datumtomField;
            }
            set
            {
                this.datumtomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumfrom
        {
            get
            {
                return this.datumfromField;
            }
            set
            {
                this.datumfromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        public string tidkod
        {
            get
            {
                return this.tidkodField;
            }
            set
            {
                this.tidkodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int postid
        {
            get
            {
                return this.postidField;
            }
            set
            {
                this.postidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlTidtransaktionerTidtransResenhet
    {

        private byte dimField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlTidtransaktionerTidtransKundnr
    {

        private string infoField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResetransaktioner
    {

        private paxmlResetransaktionerResetrans[] resetransField;

        private string landskodstdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resetrans")]
        public paxmlResetransaktionerResetrans[] resetrans
        {
            get
            {
                return this.resetransField;
            }
            set
            {
                this.resetransField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string landskodstd
        {
            get
            {
                return this.landskodstdField;
            }
            set
            {
                this.landskodstdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResetransaktionerResetrans
    {

        private string infoField;

        private string anteckningField;

        private paxmlResetransaktionerResetransResenhet[] resenheterField;

        private paxmlResetransaktionerResetransKundnr kundnrField;

        private string samlingsidField;

        private string timmarField;

        private int antlastField;

        private int antpassField;

        private int kilometerField;

        private int kmstoppField;

        private int kmstartField;

        private string ortField;

        private string syfteField;

        private string kontaktField;

        private string foretagField;

        private string bilmodellField;

        private string bilnrField;

        private string kontonrField;

        private string specifikationField;

        private string varugruppField;

        private paxmlResetransaktionerResetransDeltagare[] deltagarlistaField;

        private int antdeltagField;

        private bool ftgkortField;

        private string momsField;

        private string beloppField;

        private string valutafaktorField;

        private string valutakodField;

        private string landskodField;

        private paxmlResetransaktionerResetransFortsatt fortsattField;

        private string resekodField;

        private System.DateTime tidpunktField;

        private int postidField;

        private string anstidField;

        private string persnrField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        public string anteckning
        {
            get
            {
                return this.anteckningField;
            }
            set
            {
                this.anteckningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("resenhet", IsNullable = false)]
        public paxmlResetransaktionerResetransResenhet[] resenheter
        {
            get
            {
                return this.resenheterField;
            }
            set
            {
                this.resenheterField = value;
            }
        }

        /// <remarks/>
        public paxmlResetransaktionerResetransKundnr kundnr
        {
            get
            {
                return this.kundnrField;
            }
            set
            {
                this.kundnrField = value;
            }
        }

        /// <remarks/>
        public string samlingsid
        {
            get
            {
                return this.samlingsidField;
            }
            set
            {
                this.samlingsidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string timmar
        {
            get
            {
                return this.timmarField;
            }
            set
            {
                this.timmarField = value;
            }
        }

        /// <remarks/>
        public int antlast
        {
            get
            {
                return this.antlastField;
            }
            set
            {
                this.antlastField = value;
            }
        }

        /// <remarks/>
        public int antpass
        {
            get
            {
                return this.antpassField;
            }
            set
            {
                this.antpassField = value;
            }
        }

        /// <remarks/>
        public int kilometer
        {
            get
            {
                return this.kilometerField;
            }
            set
            {
                this.kilometerField = value;
            }
        }

        /// <remarks/>
        public int kmstopp
        {
            get
            {
                return this.kmstoppField;
            }
            set
            {
                this.kmstoppField = value;
            }
        }

        /// <remarks/>
        public int kmstart
        {
            get
            {
                return this.kmstartField;
            }
            set
            {
                this.kmstartField = value;
            }
        }

        /// <remarks/>
        public string ort
        {
            get
            {
                return this.ortField;
            }
            set
            {
                this.ortField = value;
            }
        }

        /// <remarks/>
        public string syfte
        {
            get
            {
                return this.syfteField;
            }
            set
            {
                this.syfteField = value;
            }
        }

        /// <remarks/>
        public string kontakt
        {
            get
            {
                return this.kontaktField;
            }
            set
            {
                this.kontaktField = value;
            }
        }

        /// <remarks/>
        public string foretag
        {
            get
            {
                return this.foretagField;
            }
            set
            {
                this.foretagField = value;
            }
        }

        /// <remarks/>
        public string bilmodell
        {
            get
            {
                return this.bilmodellField;
            }
            set
            {
                this.bilmodellField = value;
            }
        }

        /// <remarks/>
        public string bilnr
        {
            get
            {
                return this.bilnrField;
            }
            set
            {
                this.bilnrField = value;
            }
        }

        /// <remarks/>
        public string kontonr
        {
            get
            {
                return this.kontonrField;
            }
            set
            {
                this.kontonrField = value;
            }
        }

        /// <remarks/>
        public string specifikation
        {
            get
            {
                return this.specifikationField;
            }
            set
            {
                this.specifikationField = value;
            }
        }

        /// <remarks/>
        public string varugrupp
        {
            get
            {
                return this.varugruppField;
            }
            set
            {
                this.varugruppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("deltagare", IsNullable = false)]
        public paxmlResetransaktionerResetransDeltagare[] deltagarlista
        {
            get
            {
                return this.deltagarlistaField;
            }
            set
            {
                this.deltagarlistaField = value;
            }
        }

        /// <remarks/>
        public int antdeltag
        {
            get
            {
                return this.antdeltagField;
            }
            set
            {
                this.antdeltagField = value;
            }
        }

        /// <remarks/>
        public bool ftgkort
        {
            get
            {
                return this.ftgkortField;
            }
            set
            {
                this.ftgkortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string moms
        {
            get
            {
                return this.momsField;
            }
            set
            {
                this.momsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string belopp
        {
            get
            {
                return this.beloppField;
            }
            set
            {
                this.beloppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string valutafaktor
        {
            get
            {
                return this.valutafaktorField;
            }
            set
            {
                this.valutafaktorField = value;
            }
        }

        /// <remarks/>
        public string valutakod
        {
            get
            {
                return this.valutakodField;
            }
            set
            {
                this.valutakodField = value;
            }
        }

        /// <remarks/>
        public string landskod
        {
            get
            {
                return this.landskodField;
            }
            set
            {
                this.landskodField = value;
            }
        }

        /// <remarks/>
        public paxmlResetransaktionerResetransFortsatt fortsatt
        {
            get
            {
                return this.fortsattField;
            }
            set
            {
                this.fortsattField = value;
            }
        }

        /// <remarks/>
        public string resekod
        {
            get
            {
                return this.resekodField;
            }
            set
            {
                this.resekodField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tidpunkt
        {
            get
            {
                return this.tidpunktField;
            }
            set
            {
                this.tidpunktField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int postid
        {
            get
            {
                return this.postidField;
            }
            set
            {
                this.postidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string anstid
        {
            get
            {
                return this.anstidField;
            }
            set
            {
                this.anstidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string persnr
        {
            get
            {
                return this.persnrField;
            }
            set
            {
                this.persnrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResetransaktionerResetransResenhet
    {

        private byte dimField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResetransaktionerResetransKundnr
    {

        private string infoField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResetransaktionerResetransDeltagare
    {

        private string foretagField;

        private string namnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foretag
        {
            get
            {
                return this.foretagField;
            }
            set
            {
                this.foretagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string namn
        {
            get
            {
                return this.namnField;
            }
            set
            {
                this.namnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResetransaktionerResetransFortsatt
    {

        private int dagnrField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int dagnr
        {
            get
            {
                return this.dagnrField;
            }
            set
            {
                this.dagnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlKod
    {

        private string idField;

        private string namnField;

        private string infoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string namn
        {
            get
            {
                return this.namnField;
            }
            set
            {
                this.namnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlResultatenhet
    {

        private bool deleteField;

        private byte dimField;

        private string idField;

        private string namnField;

        private string infoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string namn
        {
            get
            {
                return this.namnField;
            }
            set
            {
                this.namnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlDimension
    {

        private byte dimField;

        private string namnField;

        private string infoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte dim
        {
            get
            {
                return this.dimField;
            }
            set
            {
                this.dimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string namn
        {
            get
            {
                return this.namnField;
            }
            set
            {
                this.namnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlHeader
    {

        private string infoField;

        private string programlicensField;

        private string programnamnField;

        private string telefaxField;

        private string telefonField;

        private string attestansvarigField;

        private string personalansvarigField;

        private string kontaktpersonField;

        private string hemsidaField;

        private string epostField;

        private string landField;

        private string ortField;

        private string postnrField;

        private string postadressField;

        private string extraadressField;

        private string foretagnamnField;

        private string foretagorgnrField;

        private string foretagidField;

        private paxmlHeaderNyexport nyexportField;

        private System.DateTime datumField;

        private decimal versionField;

        private string formatField;

        /// <remarks/>
        public string info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        public string programlicens
        {
            get
            {
                return this.programlicensField;
            }
            set
            {
                this.programlicensField = value;
            }
        }

        /// <remarks/>
        public string programnamn
        {
            get
            {
                return this.programnamnField;
            }
            set
            {
                this.programnamnField = value;
            }
        }

        /// <remarks/>
        public string telefax
        {
            get
            {
                return this.telefaxField;
            }
            set
            {
                this.telefaxField = value;
            }
        }

        /// <remarks/>
        public string telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }

        /// <remarks/>
        public string attestansvarig
        {
            get
            {
                return this.attestansvarigField;
            }
            set
            {
                this.attestansvarigField = value;
            }
        }

        /// <remarks/>
        public string personalansvarig
        {
            get
            {
                return this.personalansvarigField;
            }
            set
            {
                this.personalansvarigField = value;
            }
        }

        /// <remarks/>
        public string kontaktperson
        {
            get
            {
                return this.kontaktpersonField;
            }
            set
            {
                this.kontaktpersonField = value;
            }
        }

        /// <remarks/>
        public string hemsida
        {
            get
            {
                return this.hemsidaField;
            }
            set
            {
                this.hemsidaField = value;
            }
        }

        /// <remarks/>
        public string epost
        {
            get
            {
                return this.epostField;
            }
            set
            {
                this.epostField = value;
            }
        }

        /// <remarks/>
        public string land
        {
            get
            {
                return this.landField;
            }
            set
            {
                this.landField = value;
            }
        }

        /// <remarks/>
        public string ort
        {
            get
            {
                return this.ortField;
            }
            set
            {
                this.ortField = value;
            }
        }

        /// <remarks/>
        public string postnr
        {
            get
            {
                return this.postnrField;
            }
            set
            {
                this.postnrField = value;
            }
        }

        /// <remarks/>
        public string postadress
        {
            get
            {
                return this.postadressField;
            }
            set
            {
                this.postadressField = value;
            }
        }

        /// <remarks/>
        public string extraadress
        {
            get
            {
                return this.extraadressField;
            }
            set
            {
                this.extraadressField = value;
            }
        }

        /// <remarks/>
        public string foretagnamn
        {
            get
            {
                return this.foretagnamnField;
            }
            set
            {
                this.foretagnamnField = value;
            }
        }

        /// <remarks/>
        public string foretagorgnr
        {
            get
            {
                return this.foretagorgnrField;
            }
            set
            {
                this.foretagorgnrField = value;
            }
        }

        /// <remarks/>
        public string foretagid
        {
            get
            {
                return this.foretagidField;
            }
            set
            {
                this.foretagidField = value;
            }
        }

        /// <remarks/>
        public paxmlHeaderNyexport nyexport
        {
            get
            {
                return this.nyexportField;
            }
            set
            {
                this.nyexportField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        public decimal version
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

        /// <remarks/>
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class paxmlHeaderNyexport
    {

        private System.DateTime datumField;

        private System.DateTime datumfromField;

        private System.DateTime datumtomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datumfrom
        {
            get
            {
                return this.datumfromField;
            }
            set
            {
                this.datumfromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime datumtom
        {
            get
            {
                return this.datumtomField;
            }
            set
            {
                this.datumtomField = value;
            }
        }
    }


}
