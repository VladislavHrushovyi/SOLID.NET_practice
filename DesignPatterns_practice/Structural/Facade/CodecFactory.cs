namespace DesignPatterns_practice.Structural.Facade;

public static class CodecFactory
{
    public static ICodecCompressions GetCodecObject(VideoFile videoFile)
    {
        return videoFile.Codec switch
        {
            "mp4" => new Mpeg4CompressionCodec(),
            "ogg" => new OggCompressionCodec(),
            _ => throw new InvalidDataException()
        };
    }
}