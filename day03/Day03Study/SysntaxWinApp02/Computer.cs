﻿// using... 네임스페이스 추가
// C, C++ #include / Python import와 동일
using System;
using System.Collections.Generic;
using System.Diagnostics;   // 진단네임스페이스 Debug 클래스 포함
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysntaxWinApp02
{
    internal class MobileDevice
    {
        public MobileDevice() { }
    }

    // sealed 더이상 자식 클래스를 만들고 싶지 않을때
    internal class Computer
    {
        public Computer() {
            Debug.WriteLine("[디버그] Computer 객체 생성");
            Console.WriteLine("Computer 객체 생성");
        }

        bool powerOn;
        public void Boot() {
            Console.WriteLine("컴퓨터 부팅!");
        }
        public virtual void ShutDown() { 
            Console.WriteLine("컴퓨터 셧다운!!");
        }
        public void Reset() { }
    }

    // C++에서는 다중상속이 가능
    // Java, C#은 다중상속을 막음
    internal class Notebook : Computer, IMobile
    {
        public void call()
        {
            Console.WriteLine("노트북으로 전화걸기");
        }

        public string GetList()
        {
            string phoneList = "010-9999-9900;010-8888-7777;";
            return phoneList;
        }
        public Notebook()
        {
            Console.WriteLine("Notebook객체 생성");
            base.Boot();    // 부모클래스의 Boot() 메서드 실행
        }
        
        // 부모클래스 ShotDown을 자식에서 다시 재정의
        public override void ShutDown()
        {
            Console.WriteLine("노트북 닫기!");
        }
        bool fingerScan;    // 지문인식

        // 파라미터가 없는 메서드
        public bool HasFingerScanDevice() { return this.fingerScan; }

        // 파라미터가 있는 메서드
        public bool HasFingerScanDevice(bool fingerScan) 
        { 
            this.fingerScan = fingerScan;
            Console.WriteLine();
            return this.fingerScan;
        }

    }

    internal class Server : Computer 
    {
        public string Name {  get; set; }  // 이름 속성 추가

        public Server() { Console.WriteLine("Server객체 생성"); }

        bool storage;   // 스토리지
        public bool HasStorage() { return this.storage; }

        // 깊은 복사 메서드
        public Server DeepCopy()
        {
            return new Server { Name = this.Name };
        }
    }
}
