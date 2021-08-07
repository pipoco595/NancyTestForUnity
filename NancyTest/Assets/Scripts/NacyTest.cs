using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Nancy;
using Nancy.Hosting.Self;

// Nancy.NancyModule を継承するだけでOK
public class SampleModule : Nancy.NancyModule
{
    public SampleModule()
    {
        // 'http://localhost:12345'でアクセスされた時に処理
        //Get["/"] = x => "Hello World!";

        Get("/", x => { return "Hello World"; });
    }
}

public class NacyTest : MonoBehaviour
{
    NancyHost nancyHost = new NancyHost(new Uri("http://localhost:12345"));// ホストサーバー
    
    // Start is called before the first frame update
    void Start()
    {
        //var nancyHost = new NancyHost(new Uri("http://localhost:12345"));

        // ホストサーバー起動
        nancyHost.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        // ホストサーバー停止
        nancyHost.Stop();
    }
}
