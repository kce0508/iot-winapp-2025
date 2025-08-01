namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // 자료형
            sbyte sbtVal = 127;     // -128 ~ 127 수 저장
            System.SByte sbtVal2 = System.SByte.MinValue; // -128 할당. 잘 사용되지 않음
            byte btVal = 255;       // byte : 0 ~ 225 수 저장(1 byte 크기)
            System.Byte btVal2 = System.Byte.MaxValue;    // 0 할당
            short stVal = 32767;    // short : -32768 ~ 32767 수 저장
            System.Int16 stVal2 = System.Int16.MinValue;  // -32768 할당
            ushort ustVal = 65535;  // unsigend short : 0 ~ 65535 저장(2bytes 크기)
            System.UInt16 ustVal2 = System.UInt16.MinValue;   // 0 할당
            int intVal = 2147483647;    // int : -21억 ~ 21억 (4bytes 크기)
            System.Int32 intVal2 = System.Int32.MinValue;     // -21억 할당
            uint uintVal = 4294967295;  // unsigned int : 0 ~ 42억(4bytes 크기)
            System.UInt32 uintVal2 = System.UInt32.MinValue;  // 0 할당
            long lngVal = 9000000000000000000;   // long : -92경 ~92경
            ulong ulngVal = 18000000000000000000; // unsigned long : 1800경(8bytes 크기)
            System.Int64 longVal2;  // (8byte)
            System.Int128 bigLongVal03; // (16bytes)

            // 실수 자료형
            float fVal = 3.141592f; // float : 4bytes 소수점
            System.Single fVal2 = System.Single.MinValue;   // +-1.5e-45 할당
            double dVal = 3.141592; // double : 8bytes 소수점
            System.Double dVal2;
            decimal dcVal = 3.141592m;  // decimal : 16bytes 소수점
            System.Decimal dcVal2;

            // 문자형 타입
            char ch01 = 'A';
            System.Char ch03 = 'B';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!"; // \0 : end of line
            System.String str02 = "Hello C#";

            // 불린 타입
            bool bool01 = true;
            System.Boolean bool02 = false;

            // Nullable
            //int int02 = null;   // 기본타입(정수형, 실수형, 불린 / 문자열 제외)은 NULL을 할당불가
            int? int03 = null;  // 기본타입 뒤에 ? 붙여줄 것

            // 상수 타입
            const int int04 = 15;   // const를 만나면 상수. 한번 할당후 변경 불가
            //int04 = 26;

            // 동적 타입 // 컴파일되면서 해당 타입으로 형결정
            var int05 = false;

            //int05 = "string";


            //MessageBox.Show(intVal2.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
