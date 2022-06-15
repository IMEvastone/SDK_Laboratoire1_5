// Tout ça c'est du beau travail! - EO
namespace LibrairieConversionNote
{

    public class ConversionAlphabetiqueToNote
    {

        public string Transformer(string note)
        {
            string noteUpper = note.ToUpper();
            string notef;
            if (noteUpper == "A")
                notef = "La";
            else if (noteUpper == "B")
                notef = "Si";
            else if (noteUpper == "C")
                notef = "Do";
            else if (noteUpper == "D")
                notef = "Ré";
            else if (noteUpper == "E")
                notef = "Mi";
            else if (noteUpper == "F")
                notef = "Fa";
            else if (noteUpper == "G")
                notef = "Sol";
            else
                notef = "C'est pas une note, ca...";

            return notef;
        }
    }
}
