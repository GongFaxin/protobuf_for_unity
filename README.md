# protobuf_for_unity
google's protobuf 3.x for unity3D

来源：
[google's protobuf](https://github.com/google/protobuf/tree/master/csharp)<br>
版本号：3.x<br><br>

使用方法：<br>
将目录 Google.Protobuf 下的所有文件拷到 Unity 工程中。<br>
![](https://github.com/GongFaxin/protobuf_for_unity/raw/master/doc/Project.png)<br><br>

接下来可以参考 test_msg.proto<br>
```protobuf
syntax = "proto3";

message TheMsg {
  string name = 1;
  int32 num = 2;
}
```
以及 Test.cs<br>
```C#
void Start ()
{
    TheMsg msg = new TheMsg();
    msg.Name = "am the name";
    msg.Num = 32;

    Debug.Log(string.Format("The Msg is ( Name:{0},Num:{1} )",msg.Name,msg.Num));

    byte[] bmsg;
    using (MemoryStream ms = new MemoryStream())
    {
        msg.WriteTo(ms);
        bmsg = ms.ToArray();
    }


    TheMsg msg2 = TheMsg.Parser.ParseFrom(bmsg);
    Debug.Log(string.Format("The Msg2 is ( Name:{0},Num:{1} )",msg2.Name,msg2.Num));

}
```
测试输出：<br>
![](https://github.com/GongFaxin/protobuf_for_unity/raw/master/doc/Log.png)<br><br>
