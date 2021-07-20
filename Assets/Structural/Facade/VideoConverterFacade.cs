namespace Kuhpik.DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Just doing GOD-class job
    /// </summary>
    public class VideoConverterFacade
    {
        readonly WatermarkSystem _watermarkSystem;
        readonly AudioCompressionSystem _audioSystem;
        readonly VideoFormatHandlingSystem _formatHandlingSystem;

        public VideoConverterFacade()
        {
            //Imagine we use DI-container for these classes

            _watermarkSystem = new WatermarkSystem();
            _audioSystem = new AudioCompressionSystem();
            _formatHandlingSystem = new VideoFormatHandlingSystem();
        }

        public void Convert()
        {
            _formatHandlingSystem.ChangeFormat();
            _audioSystem.Compress();
            _watermarkSystem.TrySetWatermark();
        }
    }
}
