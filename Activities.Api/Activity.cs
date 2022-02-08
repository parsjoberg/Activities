using CsvHelper.Configuration.Attributes;

namespace Activities.Api
{
    public class Activity
    {

        //Aktivitetstyp        
        public string Aktivitetstyp { get; set; }
        //Datum        
        public string Datum { get; set; }
        //Favorit
        public string Favorit { get; set; }
        //Namn
        public string Namn { get; set; }
        //Sträcka        
        public string Sträcka { get; set; }
        //Kalorier
        public string Kalorier { get; set; }
        //Tid        
        public string Tid { get; set; }
        //Medelpuls
        public string Medelpuls { get; set; }
        //Maxpuls
        public string Maxpuls { get; set; }
        //Aerobisk TE
        [Name("Aerobisk TE")]
        public string AerobiskTE { get; set; }
        //Medellöpkadens
        //Maximal löpkadens
        [Name("Maximal löpkadens")]
        public string MaxKadens { get; set; }
        //Medeltempo
        public string Medeltempo { get; set; }
        //Bästa tempo
        [Name("Bästa tempo")]
        public string BästaTempo { get; set; }
        //Total stigning
        [Name("Total stigning")]
        public string TotalStigning { get; set; }
        //Totalt nedför
        [Name("Totalt nedför")]
        public string TotaltNedför { get; set; }
        //Medelsteglängd
        public string Medelsteglängd { get; set; }
        //Medelvärde för vertikal kvot
        [Name("Medelvärde för vertikal kvot")]
        public string MedelvärdeFörVertikalKvot { get; set; }
        //Medelvärde för vertikal rörelse
        [Name("Medelvärde för vertikal rörelse")]
        public string MedelvärdeFörVertikalRörelse { get; set; }
        //Training Stress Score®
        [Name("Training Stress Score®")]
        public string TrainingStressScore{ get; set; }
        //Intensitet        
        public string Intensitet { get; set; }
        //Flöde
        public string Flöde { get; set; }
        //Totalt antal simtag
        [Name("Totalt antal simtag")]
        public string TotaltAntalSimtag { get; set; }
        //Medel-Swolf
        [Name("Medel-Swolf")]
        public string MedelSwolf { get; set; }
        //Medelårtagstempo
        public string Medelårtagstempo { get; set; }
        //Dyktid,
        public string Dyktid { get; set; }
        //Minsta temperatur
        [Name("Minsta temperatur")]
        public string MinstaTemperatur { get; set; }
        //Ytintervall
        public string Ytintervall { get; set; }
        //Dekompression
        public string Dekompression { get; set; }
        //Bästa varvtid
        [Name("Bästa varvtid")]
        public string BästaVarvtid { get; set; }
        //Antal varv
        [Name("Antal varv")]
        public string AntalVarv { get; set; }
        //Maximal temperatur
        [Name("Maximal temperatur")]
        public string MaximalTemperatur { get; set; }
        //Färdtid
        public string Färdtid { get; set; }
        //Total tid
        [Name("Total tid")]
        public string TotalTid { get; set; }
        //Min. höjd
        [Name("Min. höjd")]
        public string MinHöjd { get; set; }
        //Max.höjd
        [Name("Max. höjd")]
        public string MaxHöjd { get; set; }


    }
}
