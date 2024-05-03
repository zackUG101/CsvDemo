using System;
using System.Collections.Generic;
using System.IO;

public class Country
{
    public string StartIp { get; set; }
    public string EndIp { get; set; }
    public long StartIpNum { get; set; }
    public long EndIpNum { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }

    public Country(string startIp, string endIp, long startIpNum, long endIpNum, string code, string name)
    {
        StartIp = startIp;
        EndIp = endIp;
        StartIpNum = startIpNum;
        EndIpNum = endIpNum;
        Code = code;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name} ({Code}) - {StartIp} to {EndIp}";
    }
}
