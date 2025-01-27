public class Program
{
    public static void Main(string[] args)
    {
        Translator translator = new EnglishTranslator();
        translator.Translate();
        translator.GetLanguage();

}
    public abstract class Translator
    {
        public abstract void Translate();

        public abstract void GetLanguage();
    }

    public class EnglishTranslator : Translator
    {
        public override void Translate()
        {
            Console.WriteLine("Я переводчик с английского");
        }

        public override void GetLanguage()
        {
            Console.WriteLine("Это английский язык");
        }
    }
}


