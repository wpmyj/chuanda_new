using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleMapViewer
{
    class GPSRevieveData
    {
    }

    //GPS DOP and Active Satellites（GSA）当前卫星信息 
    //$GPGSA,<1>,<2>,<3>,<4>,,,,,<12>,<13>,<14>, <15>,<16>,<17>,<18><CR><LF> 
    public class GPGSA
    {
        //<1>模式 ：M = 手动， A = 自动。 
        public char Mode { get; set; }
        //<2>定位型式 1 = 未定位， 2 = 二维定位， 3 = 三维定位。 
        public int Location { get; set; }
        //<3>到<14>PRN 数字：01 至 32 表天空使用中的卫星编号，最多可接收12颗卫星信息 
        public int PRN1 { get; set; }
        public int PRN2 { get; set; }
        public int PRN3 { get; set; }
        public int PRN4 { get; set; }
        public int PRN5 { get; set; }
        public int PRN6 { get; set; }
        public int PRN7 { get; set; }
        public int PRN8 { get; set; }
        public int PRN9 { get; set; }
        public int PRN10 { get; set; }
        public int PRN11 { get; set; }
        public int PRN12 { get; set; }
        //(上面蓝色处，总共有12个)。 
        //<15> PDOP位置精度因子（0.5~99.9） 
        public double PDOP { get; set; }
        //<16> HDOP水平精度因子（0.5~99.9） 
        public double HDOP { get; set; }
        //<17> VDOP垂直精度因子（0.5~99.9） 
        public double VDOP { get; set; }
        //<18> Checksum.(检查位). 
        public int Checksum { get; set; }
    }

    //GPS Satellites in View（GSV）可见卫星信息 
    //$GPGSV, <1>,<2>,<3>,<4>,<5>,<6>,<7>,?<4>,<5>,<6>,<7>,<8><CR><LF> 
    public class GPGSV
    {
        //<1> GSV语句的总数 
        public int GSVCount { get; set; }
        //<2> 本句GSV的编号 
        public int GSVNumber { get; set; }
        //<3> 可见卫星的总数，00 至 12。 
        public int VisibleSatelliteCount { get; set; }
        //<4> 卫星编号， 01 至 32。 
        public int SatelliteNumber { get; set; }
        //<5>卫星仰角， 00 至 90 度。 
        public double SatelliteElevationAngle { get; set; }
        //<6>卫星方位角， 000 至 359 度。实际值。 
        public double SatelliteAngle { get; set; }
        //<7>讯号噪声比（C/No）， 00 至 99 dB；无表未接收到讯号。
        public int NoiseRate { get; set; }
        //<8>Checksum.(检查位). 
        public int Checksum { get; set; }
    }

    //Global Positioning System Fix Data（GGA）GPS定位信息 
    //$GPGGA,<1>,<2>,<3>,<4>,<5>,<6>,<7>,<8>,<9>,M,<10>,M,<11>,<12>*hh<CR><LF>
    public class GNGGA
    {
        //<1> UTC时间，hhmmss（时分秒）格式
        public DateTime UTCTime { get; set; }
        //<2> 纬度ddmm.mmmm（度分）格式（前面的0也将被传输） 
        public double Latitude { get; set; }
        //<3> 纬度半球N（北半球）或S（南半球） 
        public char LatitudeNS { get; set; }
        //<4> 经度dddmm.mmmm（度分）格式（前面的0也将被传输） 
        public double Longitude { get; set; }
        //<5> 经度半球E（东经）或W（西经） 
        public char LongitudeEW { get; set; }
        //<6> GPS状态：0=未定位，1=非差分定位，2=差分定位，6=正在估算 
        public int Quality { get; set; }
        //<7> 正在使用解算位置的卫星数量（00~12）（前面的0也将被传输） 
        public int UseSatelliteCount { get; set; }
        //<8> HDOP水平精度因子（0.5~99.9） 
        public double precision { get; set; }
        //<9> 海拔高度（-9999.9~99999.9） 
        public double SeaLevelHeight { get; set; }
        //<10> 地球椭球面相对大地水准面的高度 
        public double GeoidalHeight { get; set; }
        //<11> 差分时间（从最近一次接收到差分信号开始的秒数，如果不是差分定位将为空） 
        public double DifferenceDeadline { get; set; }
        //<12> 差分站ID号0000~1023（前面的0也将被传输，如果不是差分定位将为空
        public double DifferenceReferenceBaseStation { get; set; }
    }

    //Recommended Minimum Specific GPS/TRANSIT Data（RMC）推荐定位信息
    //$GPRMC,<1>,<2>,<3>,<4>,<5>,<6>,<7>,<8>,<9>,<10>,<11>,<12>*hh<CR><LF> 
    public class GPRMC
    {
        //<1> UTC时间，hhmmss（时分秒）格式 
        public DateTime UTCTime { get; set; }
        //<2> 定位状态，A=有效定位，V=无效定位 
        public char LocationStatus { get; set; }
        //<3> 纬度ddmm.mmmm（度分）格式（前面的0也将被传输） 
        public double Latitude { get; set; }
        //<4> 纬度半球N（北半球）或S（南半球） 
        public char LatitudeNS { get; set; }
        //<5> 经度dddmm.mmmm（度分）格式（前面的0也将被传输） 
        public double Longitude { get; set; }
        //<6> 经度半球E（东经）或W（西经） 
        public char LongitudeEW { get; set; }
        //<7> 地面速率（000.0~999.9节，前面的0也将被传输） 
        public double GroundSpeed { get; set; }
        //<8> 地面航向（000.0~359.9度，以真北为参考基准，前面的0也将被传输） 
        public double GroundAzimuth { get; set; }
        //<9> UTC日期，ddmmyy（日月年）格式 
        public DateTime UTCDate { get; set; }
        //<10> 磁偏角（000.0~180.0度，前面的0也将被传输） 
        public double DeclinationAngle { get; set; }
        //<11> 磁偏角方向，E（东）或W（西） 
        public char DeclinationDirection { get; set; }
        //<12> 模式指示（仅NMEA0183 3.00版本输出，A=自主定位，D=差分，E=估算，N=数据无效） 
        public char ModeIndication { get; set; }
    }

    //Track Made Good and Ground Speed（VTG）地面速度信息 
    //$GPVTG,<1>,T,<2>,M,<3>,N,<4>,K,<5>*hh<CR><LF> 
    public class GPVTG
    {
        //<1> 以真北为参考基准的地面航向（000~359度，前面的0也将被传输） 
        public double TNGroundAzimuth { get; set; }
        //<2> 以磁北为参考基准的地面航向（000~359度，前面的0也将被传输） 
        public double MNGroundAzimuth { get; set; }
        //<3> 地面速率（000.0~999.9节，前面的0也将被传输） 
        public double GroundSpeed { get; set; }
        //<4> 地面速率（0000.0~1851.8公里/小时，前面的0也将被传输） 
        public double GroundSpeedKilometer { get; set; }
        //<5> 模式指示（仅NMEA0183 3.00版本输出，A=自主定位，D=差分，E=估算，N=数据无效） 
        public char ModeIndication { get; set; }
    }

    //GPZDA日期和时间 
    //$GPZDA,<1>,<2>, <3> , <4> , <5> , <6> *CC<CR><LF> 
    public class GPZDA
    {
        //<1> UTC时间，hhmmss（时分秒）格式 
        public DateTime UTCTime { get; set; }
        //<2> 日
        public string date { get; set; }
        //<3> 月
        public string Month { get; set; }
        //<4> 年
        public string Year { get; set; }
        //<5> 本地时区小时便宜量 
        public string TimezoneHour { get; set; }
        //<6>本地时区分钟便宜量 
        public string TimezoneMinitus { get; set; }
    }
}
