using UnityEngine;
using System.IO;
using Google.Protobuf;

public class Test : MonoBehaviour
{

    void Start()
    {
        TheMsg msg = new TheMsg();
        msg.Name = "am the name";
        msg.Num = 32;

        Debug.Log(string.Format("The Msg is ( Name:{0},Num:{1} )", msg.Name, msg.Num));

        byte[] bmsg;
        using (MemoryStream ms = new MemoryStream())
        {
            msg.WriteTo(ms);
            bmsg = ms.ToArray();
        }


        TheMsg msg2 = TheMsg.Parser.ParseFrom(bmsg);
        Debug.Log(string.Format("The Msg2 is ( Name:{0},Num:{1} )", msg2.Name, msg2.Num));

    }

}
