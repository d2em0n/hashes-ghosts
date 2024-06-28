using System;
using System.Text;

namespace hashes;

public class GhostsTask :
    IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>,
    IMagic
{
    private Vector vector;

    private Segment segment;

    private Cat cat;

    private Robot robot;

    private Document document;

    private byte[] content = Encoding.Default.GetBytes("Hello world");

    public void DoMagic()
    {
        vector?.Add(new Vector(1, 1));
        cat?.Rename("Murzik");
        segment?.Start?.Add(new Vector(1, 1));
        if (robot != null)        
            Robot.BatteryCapacity = 99;
        if (document != null)
            content[0] = 0;
    }

    Vector IFactory<Vector>.Create()
    {
        vector ??= new Vector(new double(), new double());
        return vector;
    }

    Segment IFactory<Segment>.Create()
    {
        segment ??= new Segment(new Vector(0, 0), new Vector(1, 1));
        return segment;
    }

    Robot IFactory<Robot>.Create()
    {
        robot ??= new Robot("r2d2");
        return robot;
    }


    Cat IFactory<Cat>.Create()
    {
        cat ??= new Cat("Barsik", "Siamese", new DateTime(1, 1, 1));
        return cat;
    }

    Document IFactory<Document>.Create()
    {   
        document ??= new Document("war and peace", Encoding.Default, this.content);
        return document;
    }
}

   
