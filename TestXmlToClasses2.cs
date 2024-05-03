using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlasserTillXml
{
    // konvertering gjord på json2csharp.com


    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Paxml));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Paxml)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "saldo")]
    public class Saldo
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "semlonutb")]
        public int Semlonutb { get; set; }

        [XmlElement(ElementName = "semlontot")]
        public int Semlontot { get; set; }

        [XmlElement(ElementName = "semspautb")]
        public int Semspautb { get; set; }

        [XmlElement(ElementName = "semspatot")]
        public int Semspatot { get; set; }

        [XmlElement(ElementName = "semforutb")]
        public int Semforutb { get; set; }

        [XmlElement(ElementName = "semfortot")]
        public int Semfortot { get; set; }

        [XmlElement(ElementName = "semobeutb")]
        public int Semobeutb { get; set; }

        [XmlElement(ElementName = "semobetot")]
        public int Semobetot { get; set; }

        [XmlElement(ElementName = "sembetutb")]
        public int Sembetutb { get; set; }

        [XmlElement(ElementName = "sembettot")]
        public int Sembettot { get; set; }

        [XmlElement(ElementName = "tidbankbel")]
        public int Tidbankbel { get; set; }

        [XmlElement(ElementName = "tidbanktim")]
        public int Tidbanktim { get; set; }

        [XmlElement(ElementName = "kompsaldo")]
        public int Kompsaldo { get; set; }

        [XmlElement(ElementName = "flexsaldo")]
        public int Flexsaldo { get; set; }

        [XmlElement(ElementName = "acknettolon")]
        public int Acknettolon { get; set; }

        [XmlElement(ElementName = "ackprelskatt")]
        public int Ackprelskatt { get; set; }

        [XmlElement(ElementName = "ackbruttolon")]
        public int Ackbruttolon { get; set; }

        [XmlElement(DataType = "date", ElementName = "datum")]
        public DateTime Datum { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "saldon")]
    public class Saldon
    {

        [XmlElement(ElementName = "saldo")]
        public List<Saldo> Saldo { get; set; }
    }

    [XmlRoot(ElementName = "resenhet")]
    public class Resenhet
    {

        [XmlAttribute(AttributeName = "dim")]
        public int Dim { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "resenheter")]
    public class Resenheter
    {

        [XmlElement(ElementName = "resenhet")]
        public List<Resenhet> Resenhet { get; set; }
    }

    [XmlRoot(ElementName = "kundnr")]
    public class Kundnr
    {

        [XmlAttribute(AttributeName = "info")]
        public string Info { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "transaktion")]
    public class Transaktion
    {

        [XmlElement(ElementName = "resenheter")]
        public Resenheter Resenheter { get; set; }

        [XmlElement(ElementName = "kundnr")]
        public Kundnr Kundnr { get; set; }

        [XmlAttribute(AttributeName = "kontonr")]
        public string Kontonr { get; set; }

        [XmlAttribute(AttributeName = "belopp")]
        public int Belopp { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "kontering")]
    public class Kontering
    {

        [XmlElement(ElementName = "transaktion")]
        public List<Transaktion> Transaktion { get; set; }
    }

    [XmlRoot(ElementName = "lonrad")]
    public class Lonrad
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "kontrolluppgift")]
        public string Kontrolluppgift { get; set; }

        [XmlElement(ElementName = "statistikkod")]
        public string Statistikkod { get; set; }

        [XmlElement(ElementName = "resenheter")]
        public Resenheter Resenheter { get; set; }

        [XmlElement(ElementName = "kundnr")]
        public Kundnr Kundnr { get; set; }

        [XmlElement(ElementName = "kontonr")]
        public string Kontonr { get; set; }

        [XmlElement(ElementName = "regional")]
        public bool Regional { get; set; }

        [XmlElement(ElementName = "avgiftprocent")]
        public int Avgiftprocent { get; set; }

        [XmlElement(ElementName = "avgifttyp")]
        public string Avgifttyp { get; set; }

        [XmlElement(ElementName = "skattprocent")]
        public int Skattprocent { get; set; }

        [XmlElement(ElementName = "skattetyp")]
        public string Skattetyp { get; set; }

        [XmlElement(ElementName = "lonetyp")]
        public string Lonetyp { get; set; }

        [XmlElement(ElementName = "belopp")]
        public int Belopp { get; set; }

        [XmlElement(ElementName = "apris")]
        public int Apris { get; set; }

        [XmlElement(ElementName = "antal")]
        public int Antal { get; set; }

        [XmlElement(ElementName = "enhet")]
        public string Enhet { get; set; }

        [XmlElement(ElementName = "dagar")]
        public int Dagar { get; set; }

        [XmlElement(ElementName = "arbetsdagar")]
        public int Arbetsdagar { get; set; }

        [XmlElement(ElementName = "timmar")]
        public int Timmar { get; set; }

        [XmlElement(DataType = "date", ElementName = "datumtom")]
        public DateTime Datumtom { get; set; }

        [XmlElement(DataType = "date", ElementName = "datumfrom")]
        public DateTime Datumfrom { get; set; }

        [XmlElement(ElementName = "kommentar")]
        public string Kommentar { get; set; }

        [XmlElement(ElementName = "benamning")]
        public string Benamning { get; set; }

        [XmlElement(ElementName = "font")]
        public string Font { get; set; }

        [XmlElement(ElementName = "lonart")]
        public string Lonart { get; set; }

        [XmlAttribute(AttributeName = "radnr")]
        public int Radnr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "lonerader")]
    public class Lonerader
    {

        [XmlElement(ElementName = "lonrad")]
        public List<Lonrad> Lonrad { get; set; }
    }

    [XmlRoot(ElementName = "lonebesked")]
    public class Lonebesked
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "kontering")]
        public Kontering Kontering { get; set; }

        [XmlElement(ElementName = "semlonutb")]
        public int Semlonutb { get; set; }

        [XmlElement(ElementName = "semlontot")]
        public int Semlontot { get; set; }

        [XmlElement(ElementName = "semspautb")]
        public int Semspautb { get; set; }

        [XmlElement(ElementName = "semspatot")]
        public int Semspatot { get; set; }

        [XmlElement(ElementName = "semforutb")]
        public int Semforutb { get; set; }

        [XmlElement(ElementName = "semfortot")]
        public int Semfortot { get; set; }

        [XmlElement(ElementName = "semobeutb")]
        public int Semobeutb { get; set; }

        [XmlElement(ElementName = "semobetot")]
        public int Semobetot { get; set; }

        [XmlElement(ElementName = "sembetutb")]
        public int Sembetutb { get; set; }

        [XmlElement(ElementName = "sembettot")]
        public int Sembettot { get; set; }

        [XmlElement(ElementName = "tidbankbel")]
        public int Tidbankbel { get; set; }

        [XmlElement(ElementName = "tidbanktim")]
        public int Tidbanktim { get; set; }

        [XmlElement(ElementName = "kompsaldo")]
        public int Kompsaldo { get; set; }

        [XmlElement(ElementName = "flexsaldo")]
        public int Flexsaldo { get; set; }

        [XmlElement(ElementName = "acknettolon")]
        public int Acknettolon { get; set; }

        [XmlElement(ElementName = "ackprelskatt")]
        public int Ackprelskatt { get; set; }

        [XmlElement(ElementName = "ackbruttolon")]
        public int Ackbruttolon { get; set; }

        [XmlElement(ElementName = "lonerader")]
        public Lonerader Lonerader { get; set; }

        [XmlElement(ElementName = "arbavgiftbel")]
        public int Arbavgiftbel { get; set; }

        [XmlElement(ElementName = "arbavgiftprc")]
        public int Arbavgiftprc { get; set; }

        [XmlElement(ElementName = "utbetalt")]
        public int Utbetalt { get; set; }

        [XmlElement(ElementName = "extraskatt")]
        public int Extraskatt { get; set; }

        [XmlElement(ElementName = "kapitalskatt")]
        public int Kapitalskatt { get; set; }

        [XmlElement(ElementName = "engangsskatt")]
        public int Engangsskatt { get; set; }

        [XmlElement(ElementName = "tabellskatt")]
        public int Tabellskatt { get; set; }

        [XmlElement(ElementName = "skattekolumn")]
        public int Skattekolumn { get; set; }

        [XmlElement(ElementName = "jamkningbel")]
        public int Jamkningbel { get; set; }

        [XmlElement(ElementName = "jamkningprc")]
        public int Jamkningprc { get; set; }

        [XmlElement(ElementName = "skattetabell")]
        public int Skattetabell { get; set; }

        [XmlElement(ElementName = "skattprocent")]
        public int Skattprocent { get; set; }

        [XmlElement(ElementName = "bankkonto")]
        public string Bankkonto { get; set; }

        [XmlElement(ElementName = "clearingnr")]
        public string Clearingnr { get; set; }

        [XmlElement(ElementName = "land")]
        public string Land { get; set; }

        [XmlElement(ElementName = "ort")]
        public string Ort { get; set; }

        [XmlElement(ElementName = "postnr")]
        public string Postnr { get; set; }

        [XmlElement(ElementName = "postadress")]
        public string Postadress { get; set; }

        [XmlElement(ElementName = "extraadress")]
        public string Extraadress { get; set; }

        [XmlElement(ElementName = "efternamn")]
        public string Efternamn { get; set; }

        [XmlElement(ElementName = "fornamn")]
        public string Fornamn { get; set; }

        [XmlElement(DataType = "date", ElementName = "betaldatum")]
        public DateTime Betaldatum { get; set; }

        [XmlElement(ElementName = "periodtext")]
        public string Periodtext { get; set; }

        [XmlElement(ElementName = "periodid")]
        public string Periodid { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "loneutbetalning")]
    public class Loneutbetalning
    {

        [XmlElement(ElementName = "lonebesked")]
        public List<Lonebesked> Lonebesked { get; set; }
    }

    [XmlRoot(ElementName = "loneutmatning")]
    public class Loneutmatning
    {

        [XmlAttribute(AttributeName = "belopp")]
        public int Belopp { get; set; }

        [XmlAttribute(AttributeName = "forbehall")]
        public int Forbehall { get; set; }
    }

    [XmlRoot(ElementName = "skattejamkning")]
    public class Skattejamkning
    {

        [XmlAttribute(AttributeName = "procent")]
        public int Procent { get; set; }

        [XmlAttribute(AttributeName = "belopp")]
        public int Belopp { get; set; }

        [XmlAttribute(AttributeName = "maxbelopp")]
        public int Maxbelopp { get; set; }
    }

    [XmlRoot(ElementName = "sysgrad")]
    public class Sysgrad
    {

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "text")]
    public class Text
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "persontexter")]
    public class Persontexter
    {

        [XmlElement(ElementName = "text")]
        public List<Text> Text { get; set; }
    }

    [XmlRoot(ElementName = "belopp")]
    public class Belopp
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "personbelopp")]
    public class Personbelopp
    {

        [XmlElement(ElementName = "belopp")]
        public List<Belopp> Belopp { get; set; }
    }

    [XmlRoot(ElementName = "manlon")]
    public class Manlon
    {

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "timlon")]
    public class Timlon
    {

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "person")]
    public class Person
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "resenheter")]
        public Resenheter Resenheter { get; set; }

        [XmlElement(ElementName = "loneutmatning")]
        public Loneutmatning Loneutmatning { get; set; }

        [XmlElement(ElementName = "skattejamkning")]
        public Skattejamkning Skattejamkning { get; set; }

        [XmlElement(ElementName = "skattekolumn")]
        public int Skattekolumn { get; set; }

        [XmlElement(ElementName = "skattetabell")]
        public int Skattetabell { get; set; }

        [XmlElement(ElementName = "semesterdagar")]
        public int Semesterdagar { get; set; }

        [XmlElement(ElementName = "sysgrad")]
        public Sysgrad Sysgrad { get; set; }

        [XmlElement(ElementName = "persontexter")]
        public Persontexter Persontexter { get; set; }

        [XmlElement(ElementName = "personbelopp")]
        public Personbelopp Personbelopp { get; set; }

        [XmlElement(ElementName = "manlon")]
        public Manlon Manlon { get; set; }

        [XmlElement(ElementName = "timlon")]
        public Timlon Timlon { get; set; }

        [XmlElement(ElementName = "innevarande")]
        public bool Innevarande { get; set; }

        [XmlElement(ElementName = "lonform")]
        public string Lonform { get; set; }

        [XmlElement(DataType = "date", ElementName = "avgdatum")]
        public DateTime Avgdatum { get; set; }

        [XmlElement(DataType = "date", ElementName = "anstdatum")]
        public DateTime Anstdatum { get; set; }

        [XmlElement(ElementName = "bankkonto")]
        public string Bankkonto { get; set; }

        [XmlElement(ElementName = "bankclearing")]
        public string Bankclearing { get; set; }

        [XmlElement(ElementName = "semesteravtal")]
        public string Semesteravtal { get; set; }

        [XmlElement(ElementName = "anstform")]
        public string Anstform { get; set; }

        [XmlElement(ElementName = "befattningskod")]
        public string Befattningskod { get; set; }

        [XmlElement(ElementName = "befattning")]
        public string Befattning { get; set; }

        [XmlElement(ElementName = "kategori")]
        public string Kategori { get; set; }

        [XmlElement(ElementName = "personaltyp")]
        public string Personaltyp { get; set; }

        [XmlElement(ElementName = "eposthem")]
        public string Eposthem { get; set; }

        [XmlElement(ElementName = "epostarb")]
        public string Epostarb { get; set; }

        [XmlElement(ElementName = "arbetstelefon")]
        public string Arbetstelefon { get; set; }

        [XmlElement(ElementName = "hemtelefon")]
        public string Hemtelefon { get; set; }

        [XmlElement(ElementName = "mobiltelefon")]
        public string Mobiltelefon { get; set; }

        [XmlElement(ElementName = "land")]
        public string Land { get; set; }

        [XmlElement(ElementName = "ort")]
        public string Ort { get; set; }

        [XmlElement(ElementName = "postnr")]
        public string Postnr { get; set; }

        [XmlElement(ElementName = "postadress")]
        public string Postadress { get; set; }

        [XmlElement(ElementName = "extraadress")]
        public string Extraadress { get; set; }

        [XmlElement(ElementName = "efternamn")]
        public string Efternamn { get; set; }

        [XmlElement(ElementName = "fornamn")]
        public string Fornamn { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlAttribute(AttributeName = "delete")]
        public bool Delete { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "personal")]
    public class Personal
    {

        [XmlElement(ElementName = "person")]
        public List<Person> Person { get; set; }
    }

    [XmlRoot(ElementName = "dag")]
    public class Dag
    {

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlAttribute(DataType = "time", AttributeName = "starttid")]
        public DateTime Starttid { get; set; }

        [XmlAttribute(DataType = "time", AttributeName = "sluttid")]
        public DateTime Sluttid { get; set; }

        [XmlAttribute(AttributeName = "timmar")]
        public decimal Timmar { get; set; }
    }

    [XmlRoot(ElementName = "schema")]
    public class Schema
    {

        [XmlElement(ElementName = "dag")]
        public List<Dag> Dag { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }
    }

    [XmlRoot(ElementName = "schematransaktioner")]
    public class Schematransaktioner
    {

        [XmlElement(ElementName = "schema")]
        public List<Schema> Schema { get; set; }
    }

    [XmlRoot(ElementName = "lonetrans")]
    public class Lonetrans
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "resenheter")]
        public Resenheter Resenheter { get; set; }

        [XmlElement(ElementName = "kundnr")]
        public Kundnr Kundnr { get; set; }

        [XmlElement(ElementName = "kontonr")]
        public string Kontonr { get; set; }

        [XmlElement(ElementName = "samlingsid")]
        public string Samlingsid { get; set; }

        [XmlElement(ElementName = "moms")]
        public int Moms { get; set; }

        [XmlElement(ElementName = "varugrupp")]
        public string Varugrupp { get; set; }

        [XmlElement(ElementName = "belopp")]
        public int Belopp { get; set; }

        [XmlElement(ElementName = "apris")]
        public int Apris { get; set; }

        [XmlElement(ElementName = "antal")]
        public decimal Antal { get; set; }

        [XmlElement(DataType = "dateTime", ElementName = "datumtom")]
        public DateTime Datumtom { get; set; }

        [XmlElement(DataType = "dateTime", ElementName = "datumfrom")]
        public DateTime Datumfrom { get; set; }

        [XmlElement(DataType = "date", ElementName = "datum")]
        public DateTime Datum { get; set; }

        [XmlElement(ElementName = "kommentar")]
        public string Kommentar { get; set; }

        [XmlElement(ElementName = "benamning")]
        public string Benamning { get; set; }

        [XmlElement(ElementName = "lonart")]
        public string Lonart { get; set; }

        [XmlElement(ElementName = "lonkod")]
        public string Lonkod { get; set; }

        [XmlAttribute(AttributeName = "postid")]
        public int Postid { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "lonetransaktioner")]
    public class Lonetransaktioner
    {

        [XmlElement(ElementName = "lonetrans")]
        public List<Lonetrans> Lonetrans { get; set; }
    }

    [XmlRoot(ElementName = "klar")]
    public class Klar
    {

        [XmlAttribute(AttributeName = "postid")]
        public int Postid { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumfrom")]
        public DateTime Datumfrom { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumtom")]
        public DateTime Datumtom { get; set; }
    }

    [XmlRoot(ElementName = "attesterat")]
    public class Attesterat
    {

        [XmlAttribute(AttributeName = "postid")]
        public int Postid { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumfrom")]
        public DateTime Datumfrom { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumtom")]
        public DateTime Datumtom { get; set; }
    }

    [XmlRoot(ElementName = "tidtrans")]
    public class Tidtrans
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "resenheter")]
        public Resenheter Resenheter { get; set; }

        [XmlElement(ElementName = "kundnr")]
        public Kundnr Kundnr { get; set; }

        [XmlElement(ElementName = "kontonr")]
        public string Kontonr { get; set; }

        [XmlElement(ElementName = "semgrund")]
        public bool Semgrund { get; set; }

        [XmlElement(ElementName = "samlingsid")]
        public string Samlingsid { get; set; }

        [XmlElement(ElementName = "barn")]
        public string Barn { get; set; }

        [XmlElement(ElementName = "omfattning")]
        public int Omfattning { get; set; }

        [XmlElement(ElementName = "timmar")]
        public int Timmar { get; set; }

        [XmlElement(DataType = "dateTime", ElementName = "sluttid")]
        public DateTime Sluttid { get; set; }

        [XmlElement(DataType = "dateTime", ElementName = "starttid")]
        public DateTime Starttid { get; set; }

        [XmlElement(DataType = "date", ElementName = "datumtom")]
        public DateTime Datumtom { get; set; }

        [XmlElement(DataType = "date", ElementName = "datumfrom")]
        public DateTime Datumfrom { get; set; }

        [XmlElement(DataType = "date", ElementName = "datum")]
        public DateTime Datum { get; set; }

        [XmlElement(ElementName = "tidkod")]
        public string Tidkod { get; set; }

        [XmlAttribute(AttributeName = "postid")]
        public int Postid { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "tidtransaktioner")]
    public class Tidtransaktioner
    {

        [XmlElement(ElementName = "klar")]
        public List<Klar> Klar { get; set; }

        [XmlElement(ElementName = "attesterat")]
        public List<Attesterat> Attesterat { get; set; }

        [XmlElement(ElementName = "tidtrans")]
        public List<Tidtrans> Tidtrans { get; set; }
    }

    [XmlRoot(ElementName = "deltagare")]
    public class Deltagare
    {

        [XmlAttribute(AttributeName = "foretag")]
        public string Foretag { get; set; }

        [XmlAttribute(AttributeName = "namn")]
        public string Namn { get; set; }
    }

    [XmlRoot(ElementName = "deltagarlista")]
    public class Deltagarlista
    {

        [XmlElement(ElementName = "deltagare")]
        public List<Deltagare> Deltagare { get; set; }
    }

    [XmlRoot(ElementName = "fortsatt")]
    public class Fortsatt
    {

        [XmlAttribute(AttributeName = "dagnr")]
        public int Dagnr { get; set; }

        [XmlText]
        public bool Text { get; set; }
    }

    [XmlRoot(ElementName = "resetrans")]
    public class Resetrans
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "anteckning")]
        public string Anteckning { get; set; }

        [XmlElement(ElementName = "resenheter")]
        public Resenheter Resenheter { get; set; }

        [XmlElement(ElementName = "kundnr")]
        public Kundnr Kundnr { get; set; }

        [XmlElement(ElementName = "samlingsid")]
        public string Samlingsid { get; set; }

        [XmlElement(ElementName = "timmar")]
        public int Timmar { get; set; }

        [XmlElement(ElementName = "antlast")]
        public int Antlast { get; set; }

        [XmlElement(ElementName = "antpass")]
        public int Antpass { get; set; }

        [XmlElement(ElementName = "kilometer")]
        public int Kilometer { get; set; }

        [XmlElement(ElementName = "kmstopp")]
        public int Kmstopp { get; set; }

        [XmlElement(ElementName = "kmstart")]
        public int Kmstart { get; set; }

        [XmlElement(ElementName = "ort")]
        public string Ort { get; set; }

        [XmlElement(ElementName = "syfte")]
        public string Syfte { get; set; }

        [XmlElement(ElementName = "kontakt")]
        public string Kontakt { get; set; }

        [XmlElement(ElementName = "foretag")]
        public string Foretag { get; set; }

        [XmlElement(ElementName = "bilmodell")]
        public string Bilmodell { get; set; }

        [XmlElement(ElementName = "bilnr")]
        public string Bilnr { get; set; }

        [XmlElement(ElementName = "kontonr")]
        public string Kontonr { get; set; }

        [XmlElement(ElementName = "specifikation")]
        public string Specifikation { get; set; }

        [XmlElement(ElementName = "varugrupp")]
        public string Varugrupp { get; set; }

        [XmlElement(ElementName = "deltagarlista")]
        public Deltagarlista Deltagarlista { get; set; }

        [XmlElement(ElementName = "antdeltag")]
        public int Antdeltag { get; set; }

        [XmlElement(ElementName = "ftgkort")]
        public bool Ftgkort { get; set; }

        [XmlElement(ElementName = "moms")]
        public int Moms { get; set; }

        [XmlElement(ElementName = "belopp")]
        public int Belopp { get; set; }

        [XmlElement(ElementName = "valutafaktor")]
        public int Valutafaktor { get; set; }

        [XmlElement(ElementName = "valutakod")]
        public string Valutakod { get; set; }

        [XmlElement(ElementName = "landskod")]
        public string Landskod { get; set; }

        [XmlElement(ElementName = "fortsatt")]
        public Fortsatt Fortsatt { get; set; }

        [XmlElement(ElementName = "resekod")]
        public string Resekod { get; set; }

        [XmlElement(ElementName = "tidpunkt")]
        public DateTime Tidpunkt { get; set; }

        [XmlAttribute(AttributeName = "postid")]
        public int Postid { get; set; }

        [XmlAttribute(AttributeName = "anstid")]
        public string Anstid { get; set; }

        [XmlAttribute(AttributeName = "persnr")]
        public string Persnr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "resetransaktioner")]
    public class Resetransaktioner
    {

        [XmlElement(ElementName = "resetrans")]
        public List<Resetrans> Resetrans { get; set; }

        [XmlAttribute(AttributeName = "landskodstd")]
        public string Landskodstd { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "kod")]
    public class Kod
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "namn")]
        public string Namn { get; set; }

        [XmlAttribute(AttributeName = "info")]
        public string Info { get; set; }
    }

    [XmlRoot(ElementName = "koder")]
    public class Koder
    {

        [XmlElement(ElementName = "kod")]
        public List<Kod>? Kod { get; set; }
    }

    [XmlRoot(ElementName = "resultatenhet")]
    public class Resultatenhet
    {

        [XmlAttribute(AttributeName = "delete")]
        public bool Delete { get; set; }

        [XmlAttribute(AttributeName = "dim")]
        public int Dim { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "namn")]
        public string Namn { get; set; }

        [XmlAttribute(AttributeName = "info")]
        public string Info { get; set; }
    }

    [XmlRoot(ElementName = "resultatenheter")]
    public class Resultatenheter
    {

        [XmlElement(ElementName = "resultatenhet")]
        public List<Resultatenhet> Resultatenhet { get; set; }
    }

    [XmlRoot(ElementName = "dimension")]
    public class Dimension
    {

        [XmlAttribute(AttributeName = "dim")]
        public int Dim { get; set; }

        [XmlAttribute(AttributeName = "namn")]
        public string Namn { get; set; }

        [XmlAttribute(AttributeName = "info")]
        public string Info { get; set; }
    }

    [XmlRoot(ElementName = "dimensioner")]
    public class Dimensioner
    {

        [XmlElement(ElementName = "dimension")]
        public List<Dimension> Dimension { get; set; }
    }

    [XmlRoot(ElementName = "nyexport")]
    public class Nyexport
    {

        [XmlAttribute(DataType = "date", AttributeName = "datum")]
        public DateTime Datum { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumfrom")]
        public DateTime Datumfrom { get; set; }

        [XmlAttribute(DataType = "date", AttributeName = "datumtom")]
        public DateTime Datumtom { get; set; }
    }

    [XmlRoot(ElementName = "header")]  
    public class Header
    {

        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        [XmlElement(ElementName = "programlicens")]
        public string Programlicens { get; set; }

        [XmlElement(ElementName = "programnamn")]
        public string Programnamn { get; set; }

        [XmlElement(ElementName = "telefax")]
        public string Telefax { get; set; }

        [XmlElement(ElementName = "telefon")]
        public string Telefon { get; set; }

        [XmlElement(ElementName = "attestansvarig")]
        public string Attestansvarig { get; set; }

        [XmlElement(ElementName = "personalansvarig")]
        public string Personalansvarig { get; set; }

        [XmlElement(ElementName = "kontaktperson")]
        public string Kontaktperson { get; set; }

        [XmlElement(ElementName = "hemsida")]
        public string Hemsida { get; set; }

        [XmlElement(ElementName = "epost")]
        public string Epost { get; set; }

        [XmlElement(ElementName = "land")]
        public string Land { get; set; }

        [XmlElement(ElementName = "ort")]
        public string Ort { get; set; }

        [XmlElement(ElementName = "postnr")]
        public string Postnr { get; set; }

        [XmlElement(ElementName = "postadress")]
        public string Postadress { get; set; }

        [XmlElement(ElementName = "extraadress")]
        public string Extraadress { get; set; }

        [XmlElement(ElementName = "foretagnamn")]
        public string Foretagnamn { get; set; }

        [XmlElement(ElementName = "foretagorgnr")]
        public string Foretagorgnr { get; set; }

        [XmlElement(ElementName = "foretagid")]
        public string Foretagid { get; set; }

        [XmlElement(ElementName = "nyexport")]
        public Nyexport Nyexport { get; set; }

        [XmlElement(DataType = "dateTime", ElementName = "datum")]
        public DateTime Datum { get; set; }

        [XmlElement(ElementName = "version")]
        public decimal Version { get; set; }

        [XmlElement(ElementName = "format")]
        public string Format { get; set; }
    }

    [XmlRoot(ElementName = "paxml")]
    public class Paxml
    {

        [XmlElement(ElementName = "saldon")]
        public Saldon Saldon { get; set; }

        [XmlElement(ElementName = "loneutbetalning")]
        public Loneutbetalning Loneutbetalning { get; set; }

        [XmlElement(ElementName = "personal")]
        public Personal Personal { get; set; }

        [XmlElement(ElementName = "schematransaktioner")]
        public Schematransaktioner Schematransaktioner { get; set; }

        [XmlElement(ElementName = "lonetransaktioner")]
        public Lonetransaktioner Lonetransaktioner { get; set; }

        [XmlElement(ElementName = "tidtransaktioner")]
        public Tidtransaktioner Tidtransaktioner { get; set; }

        [XmlElement(ElementName = "resetransaktioner")]
        public Resetransaktioner Resetransaktioner { get; set; }

        [XmlElement(ElementName = "koder")]
        public Koder Koder { get; set; }

        [XmlElement(ElementName = "resultatenheter")]
        public Resultatenheter Resultatenheter { get; set; }

        [XmlElement(ElementName = "dimensioner")]
        public Dimensioner Dimensioner { get; set; }

        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }
    }


}
