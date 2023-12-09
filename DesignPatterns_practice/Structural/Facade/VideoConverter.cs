namespace DesignPatterns_practice.Structural.Facade;

public class VideoConverter
{
    public void Convert()
    {
        var file = new VideoFile("test.mp4");
        var sourceCodec = CodecFactory.GetCodecObject(file);
        ICodecCompressions destinationCodec = file.Codec == "mp4" ? new OggCompressionCodec() : new Mpeg4CompressionCodec();
        var buffer = BitrateReader.Read(file.FileName, sourceCodec.Name);
        var result = BitrateReader.Convert(buffer, destinationCodec.Name);
        
        AudioMixer.Fix(result);
    }
}