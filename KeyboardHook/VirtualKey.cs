using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Snapshot.KeyboardHook
{
    [Serializable(), Flags()]
    public enum VirtualKey
    {
        //http://delphi.about.com/od/objectpascalide/l/blvkc.htm

        [XmlEnum(Name = "VK_LBUTTON")]
        VK_LBUTTON = 0X01,//Leftmouse
        [XmlEnum(Name = "VK_RBUTTON")]
        VK_RBUTTON = 0X02,//Rightmouse
        //VK_CANCEL=0X03,
        [XmlEnum(Name = "VK_MBUTTON")]
        VK_MBUTTON = 0X04,
        [XmlEnum(Name = "VK_BACK")]
        VK_BACK = 0X08,//Backspace
        [XmlEnum(Name = "VK_TAB")]
        VK_TAB = 0X09,
        //VK_CLEAR=0X0C,
        [XmlEnum(Name = "VK_RETURN")]
        VK_RETURN = 0X0D,//Enter
        [XmlEnum(Name = "VK_SHIFT")]
        VK_SHIFT = 0X10,
        [XmlEnum(Name = "VK_CONTROL")]
        VK_CONTROL = 0X11,//CTRL
        //VK_MENU=0X12,
        [XmlEnum(Name = "VK_PAUSE")]
        VK_PAUSE = 0X13,
        [XmlEnum(Name = "VK_CAPITAL")]
        VK_CAPITAL = 0X14,//Caps-Lock
        [XmlEnum(Name = "VK_ESCAPE")]
        VK_ESCAPE = 0X1B,
        [XmlEnum(Name = "VK_SPACE")]
        VK_SPACE = 0X20,
        [XmlEnum(Name = "VK_PRIOR")]
        VK_PRIOR = 0X21,//Page-Up
        [XmlEnum(Name = "VK_NEXT")]
        VK_NEXT = 0X22,//Page-Down
        [XmlEnum(Name = "VK_END")]
        VK_END = 0X23,
        [XmlEnum(Name = "VK_HOME")]
        VK_HOME = 0X24,
        [XmlEnum(Name = "VK_LEFT")]
        VK_LEFT = 0X25,
        [XmlEnum(Name = "VK_UP")]
        VK_UP = 0X26,
        [XmlEnum(Name = "VK_RIGHT")]
        VK_RIGHT = 0X27,
        [XmlEnum(Name = "VK_DOWN")]
        VK_DOWN = 0X28,
        //VK_SELECT=0X29,
        [XmlEnum(Name = "VK_PRINT")]
        VK_PRINT = 0X2A,
        //VK_EXECUTE=0X2B,
        [XmlEnum(Name = "VK_SNAPSHOT")]
        VK_SNAPSHOT = 0X2C,//PrintScreen
        [XmlEnum(Name = "VK_INSERT")]
        VK_INSERT = 0X2D,
        [XmlEnum(Name = "VK_DELETE")]
        VK_DELETE = 0X2E,
        //VK_HELP=0X2F,

        [XmlEnum(Name = "VK_0")]
        VK_0 = 0X30,
        [XmlEnum(Name = "VK_1")]
        VK_1 = 0X31,
        [XmlEnum(Name = "VK_2")]
        VK_2 = 0X32,
        [XmlEnum(Name = "VK_3")]
        VK_3 = 0X33,
        [XmlEnum(Name = "VK_4")]
        VK_4 = 0X34,
        [XmlEnum(Name = "VK_5")]
        VK_5 = 0X35,
        [XmlEnum(Name = "VK_6")]
        VK_6 = 0X36,
        [XmlEnum(Name = "VK_7")]
        VK_7 = 0X37,
        [XmlEnum(Name = "VK_8")]
        VK_8 = 0X38,
        [XmlEnum(Name = "VK_9")]
        VK_9 = 0X39,

        [XmlEnum(Name = "VK_A")]
        VK_A = 0X41,
        [XmlEnum(Name = "VK_B")]
        VK_B = 0X42,
        [XmlEnum(Name = "VK_C")]
        VK_C = 0X43,
        [XmlEnum(Name = "VK_D")]
        VK_D = 0X44,
        [XmlEnum(Name = "VK_E")]
        VK_E = 0X45,
        [XmlEnum(Name = "VK_F")]
        VK_F = 0X46,
        [XmlEnum(Name = "VK_G")]
        VK_G = 0X47,
        [XmlEnum(Name = "VK_H")]
        VK_H = 0X48,
        [XmlEnum(Name = "VK_I")]
        VK_I = 0X49,
        [XmlEnum(Name = "VK_J")]
        VK_J = 0X4A,
        [XmlEnum(Name = "VK_K")]
        VK_K = 0X4B,
        [XmlEnum(Name = "VK_L")]
        VK_L = 0X4C,
        [XmlEnum(Name = "VK_M")]
        VK_M = 0X4D,
        [XmlEnum(Name = "VK_N")]
        VK_N = 0X4E,
        [XmlEnum(Name = "VK_O")]
        VK_O = 0X4F,
        [XmlEnum(Name = "VK_P")]
        VK_P = 0X50,
        [XmlEnum(Name = "VK_Q")]
        VK_Q = 0X51,
        [XmlEnum(Name = "VK_R")]
        VK_R = 0X52,
        [XmlEnum(Name = "VK_S")]
        VK_S = 0X53,
        [XmlEnum(Name = "VK_T")]
        VK_T = 0X54,
        [XmlEnum(Name = "VK_U")]
        VK_U = 0X55,
        [XmlEnum(Name = "VK_V")]
        VK_V = 0X56,
        [XmlEnum(Name = "VK_W")]
        VK_W = 0X57,
        [XmlEnum(Name = "VK_X")]
        VK_X = 0X58,
        [XmlEnum(Name = "VK_Y")]
        VK_Y = 0X59,
        [XmlEnum(Name = "VK_Z")]
        VK_Z = 0X5A,

        [XmlEnum(Name = "VK_NUMPAD0")]
        VK_NUMPAD0 = 0X60,
        [XmlEnum(Name = "VK_NUMPAD1")]
        VK_NUMPAD1 = 0X61,
        [XmlEnum(Name = "VK_NUMPAD2")]
        VK_NUMPAD2 = 0X62,
        [XmlEnum(Name = "VK_NUMPAD3")]
        VK_NUMPAD3 = 0X63,
        [XmlEnum(Name = "VK_NUMPAD4")]
        VK_NUMPAD4 = 0X64,
        [XmlEnum(Name = "VK_NUMPAD5")]
        VK_NUMPAD5 = 0X65,
        [XmlEnum(Name = "VK_NUMPAD6")]
        VK_NUMPAD6 = 0X66,
        [XmlEnum(Name = "VK_NUMPAD7")]
        VK_NUMPAD7 = 0X67,
        [XmlEnum(Name = "VK_NUMPAD8")]
        VK_NUMPAD8 = 0X68,
        [XmlEnum(Name = "VK_NUMPAD9")]
        VK_NUMPAD9 = 0X69,

        [XmlEnum(Name = "VK_SEPERATOR")]
        VK_SEPERATOR = 0X6C, //|
        [XmlEnum(Name = "VK_SUBTRACT")]
        VK_SUBTRACT = 0X6D,   //-
        [XmlEnum(Name = "VK_DECIMAL")]
        VK_DECIMAL = 0X6E,     //.
        [XmlEnum(Name = "VK_DIVIDE")]
        VK_DIVIDE = 0X6F,       // /

        [XmlEnum(Name = "VK_F1")]
        VK_F1 = 0X70,
        [XmlEnum(Name = "VK_F2")]
        VK_F2 = 0X71,
        [XmlEnum(Name = "VK_F3")]
        VK_F3 = 0X72,
        [XmlEnum(Name = "VK_F4")]
        VK_F4 = 0X73,
        [XmlEnum(Name = "VK_F5")]
        VK_F5 = 0X74,
        [XmlEnum(Name = "VK_F6")]
        VK_F6 = 0X75,
        [XmlEnum(Name = "VK_F7")]
        VK_F7 = 0X76,
        [XmlEnum(Name = "VK_F8")]
        VK_F8 = 0X77,
        [XmlEnum(Name = "VK_F9")]
        VK_F9 = 0X78,
        [XmlEnum(Name = "VK_F10")]
        VK_F10 = 0X79,
        [XmlEnum(Name = "VK_F11")]
        VK_F11 = 0X7A,
        [XmlEnum(Name = "VK_F12")]
        VK_F12 = 0X7B,

        [XmlEnum(Name = "VK_NUMLOCK")]
        VK_NUMLOCK = 0X90,
        [XmlEnum(Name = "VK_SCROLL")]
        VK_SCROLL = 0X91,//Scroll-Lock
        [XmlEnum(Name = "VK_LSHIFT")]
        VK_LSHIFT = 0XA0,
        [XmlEnum(Name = "VK_RSHIFT")]
        VK_RSHIFT = 0XA1,
        [XmlEnum(Name = "VK_LCONTROL")]
        VK_LCONTROL = 0XA2,
        [XmlEnum(Name = "VK_RCONTROL")]
        VK_RCONTROL = 0XA3
        //VK_LMENU=0XA4,
        //VK_RMENU=0XA5,
        //VK_PLAY=0XFA,
        //VK_ZOOM=0XFB  
    } 
}
