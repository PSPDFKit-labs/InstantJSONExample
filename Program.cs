namespace InstantJSONExample
{
    class Test
    {
        static void Main(string[] args)
        {
            PSPDFKit.Sdk.InitializeTrial();

            GC.TryStartNoGCRegion(1000000000);
            
            var test = new InstantJson();
            test.RunInstantJsonConcurrently();
            Console.WriteLine("Done!");

            GC.EndNoGCRegion();
        }
    }
}