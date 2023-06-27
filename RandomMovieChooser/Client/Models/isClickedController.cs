using System.Text;

namespace RandomMovieChooser.Client.Models
{
    static class isClickedController
    {
        public static bool ActionIsClicked = false;
        public static bool AnimationIsClicked = false;
        public static bool AdventureIsClicked = false;
        public static bool ComedyIsClicked = false;
        public static bool CrimeIsClicked = false;
        public static bool DocumentaryIsClicked = false;
        public static bool DramaIsClicked = false;
        public static bool FamilyIsClicked = false;
        public static bool FantasyIsClicked = false;
        public static bool HistoryIsClicked = false;
        public static bool HorrorIsClicked = false;
        public static bool MusicIsClicked = false;
        public static bool MysteryIsClicked = false;
        public static bool RomanceIsClicked = false;
        public static bool ScifiIsClicked = false;
        public static bool TvMovieIsClicked = false;
        public static bool ThrillerIsClicked = false;
        public static bool WarIsClicked = false;
        public static bool WesternIsClicked = false;

        public static void actionClick()
        {
            isClickedController.ActionIsClicked = !(isClickedController.ActionIsClicked);
        }
        public static void animationClick()
        {
            isClickedController.AnimationIsClicked = !(isClickedController.AnimationIsClicked);
        }
        public static void adventureClick()
        {
            isClickedController.AdventureIsClicked = !(isClickedController.AdventureIsClicked);
        }
        public static void comedyClick()
        {
            isClickedController.ComedyIsClicked = !(isClickedController.ComedyIsClicked);
        }
        public static void crimeClick()
        {
            isClickedController.CrimeIsClicked = !(isClickedController.CrimeIsClicked);
        }
        public static void documentaryClick()
        {
            isClickedController.DocumentaryIsClicked = !(isClickedController.DocumentaryIsClicked);
        }
        public static void dramaClick()
        {
            isClickedController.DramaIsClicked = !(isClickedController.DramaIsClicked);
        }
        public static void familyClick()
        {
            isClickedController.FamilyIsClicked = !(isClickedController.FamilyIsClicked);
        }
        public static void fantasyClick()
        {
            isClickedController.FantasyIsClicked = !(isClickedController.FantasyIsClicked);
        }
        public static void historyClick()
        {
            isClickedController.HistoryIsClicked = !(isClickedController.HistoryIsClicked);
        }
        public static void horrorClick()
        {
            isClickedController.HorrorIsClicked = !(isClickedController.HorrorIsClicked);
        }
        public static void musicClick()
        {
            isClickedController.MusicIsClicked = !(isClickedController.MusicIsClicked);
        }
        public static void mysteryClick()
        {
            isClickedController.MysteryIsClicked = !(isClickedController.MysteryIsClicked);
        }
        public static void romanceClick()
        {
            isClickedController.RomanceIsClicked = !(isClickedController.RomanceIsClicked);
        }
        public static void scifiClick()
        {
            isClickedController.ScifiIsClicked = !(isClickedController.ScifiIsClicked);
        }
        public static void tvMovieClick()
        {
            isClickedController.TvMovieIsClicked = !(isClickedController.TvMovieIsClicked);
        }
        public static void thrillerClick()
        {
            isClickedController.ThrillerIsClicked = !(isClickedController.ThrillerIsClicked);
        }
        public static void warClick()
        {
            isClickedController.WarIsClicked = !(isClickedController.WarIsClicked);
        }
        public static void westernClick()
        {
            isClickedController.WesternIsClicked = !(isClickedController.WesternIsClicked);
        }
    
    public static string createAPIQuery()
        {
            StringBuilder sb = new StringBuilder();
            if (AnimationIsClicked)
            {
                sb.Append("Animation,");
            }
            if (ActionIsClicked)
            {
                sb.Append("Action,");
            }
            if (AdventureIsClicked)
            {
                sb.Append("Adventure,");
            }
            if (ComedyIsClicked)
            {
                sb.Append("Comedy,");
            }
            if (CrimeIsClicked)
            {
                sb.Append("Crime,");
            }
            if (DocumentaryIsClicked)
            {
                sb.Append("Documentary,");
            }
            if (DramaIsClicked)
            {
                sb.Append("Drama,");
            }
            if (FamilyIsClicked)
            {
                sb.Append("Family,");
            }
            if (FantasyIsClicked)
            {
                sb.Append("Fantasy,");
            }
            if (HistoryIsClicked)
            {
                sb.Append("History,");
            }
            if (HorrorIsClicked)
            {
                sb.Append("Horro,");
            }
            if (MusicIsClicked)
            {
                sb.Append("Music,");
            }
            if (MysteryIsClicked)
            {
                sb.Append("Mystery,");
            }
            if (RomanceIsClicked)
            {
                sb.Append("Romance,");
            }
            if (ScifiIsClicked)
            {
                sb.Append("Science Fiction,");
            }
            if (TvMovieIsClicked)
            {
                sb.Append("TV Movie,");
            }
            if (ThrillerIsClicked)
            {
                sb.Append("Thriller,");
            }
            if (WarIsClicked)
            {
                sb.Append("War,");
            }
            if (WesternIsClicked)
            {
                sb.Append("Western,");
            }
            string query = sb.ToString();
            return query;

        }
    
    
    }



}
