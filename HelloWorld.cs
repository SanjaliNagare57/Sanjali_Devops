using System;
using System.IO;

namespace junkbox.webapi
{
public class HelloWorld
{
public String Helloworld {get; set;}
public HelloWorld()
{
    if(File.Exists("HelloWorld.txt"))
    {
        Helloworld = File.ReadAllText("helloworld.txt");
    }
    else
    {
        Helloworld="??";
    }
}
}

}