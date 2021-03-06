using Roccat_Talk.TalkFX;
using System;
using System.Runtime.InteropServices;

namespace Roccat_Talk
{
    internal static class TalkFxBindings
    {
        [DllImport("talkfx-c-x86.dll", EntryPoint = "newRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr newRoccatTalkHandle_x86();

        [DllImport("talkfx-c.dll", EntryPoint = "newRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr newRoccatTalkHandle_x64();


        [DllImport("talkfx-c-x86.dll", EntryPoint = "destroyRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroyRoccatTalkHandle_x86(IntPtr handle);

        [DllImport("talkfx-c.dll", EntryPoint = "destroyRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroyRoccatTalkHandle_x64(IntPtr handle);


        internal static class TalkFX
        {
            [DllImport("talkfx-c-x86.dll", EntryPoint = "Set_LED_RGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_LED_RGB_x86(IntPtr handle, byte bZone, byte bEffect, byte bSpeed, byte colorR, byte colorG, byte colorB);

            [DllImport("talkfx-c.dll", EntryPoint = "Set_LED_RGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_LED_RGB_x64(IntPtr handle, byte bZone, byte bEffect, byte bSpeed, byte colorR, byte colorG, byte colorB);


            /* TALK FX method -- restore user LED colour at end of program */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "RestoreLEDRGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void RestoreLEDRGB_x86(IntPtr handle);

            [DllImport("talkfx-c.dll", EntryPoint = "RestoreLEDRGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void RestoreLEDRGB_x64(IntPtr handle);
        }

        internal static class RyosMKPRO
        {
            //Ryos MK PRO METHODS
            /* initiate connection to Ryos MK PRO keyboard and check if present */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "init_ryos_talk", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool init_ryos_talk_x86(IntPtr handle);

            [DllImport("talkfx-c.dll", EntryPoint = "init_ryos_talk", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool init_ryos_talk_x64(IntPtr handle);


            /* take control of a connected Ryos MK PRO keyboard */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "set_ryos_kb_SDKmode", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool set_ryos_kb_SDKmode_x86(IntPtr handle, bool state);

            [DllImport("talkfx-c.dll", EntryPoint = "set_ryos_kb_SDKmode", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool set_ryos_kb_SDKmode_x64(IntPtr handle, bool state);


            /* basic Ryos MK PRO LED control methods */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "turn_off_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_off_all_LEDS_x86(IntPtr handle);

            [DllImport("talkfx-c.dll", EntryPoint = "turn_off_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_off_all_LEDS_x64(IntPtr handle);


            [DllImport("talkfx-c-x86.dll", EntryPoint = "turn_on_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_on_all_LEDS_x86(IntPtr handle);

            [DllImport("talkfx-c.dll", EntryPoint = "turn_on_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_on_all_LEDS_x64(IntPtr handle);


            /* turn on/off a single LED at specified position */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "set_LED_on", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_on_x86(IntPtr handle, byte ucPos);

            [DllImport("talkfx-c.dll", EntryPoint = "set_LED_on", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_on_x64(IntPtr handle, byte ucPos);


            [DllImport("talkfx-c-x86.dll", EntryPoint = "set_LED_off", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_off_x86(IntPtr handle, byte ucPos);

            [DllImport("talkfx-c.dll", EntryPoint = "set_LED_off", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_off_x64(IntPtr handle, byte ucPos);


            /* send a whole array as a frame to the keyboard (manipulate mulitple LEDS)*/
            [DllImport("talkfx-c-x86.dll", EntryPoint = "Set_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDS_x86(IntPtr handle, byte[] ucLED);

            [DllImport("talkfx-c.dll", EntryPoint = "Set_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDS_x64(IntPtr handle, byte[] ucLED);


            /* simple blinking effect on Ryos MK PRO */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "All_Key_Blinking", CallingConvention = CallingConvention.Cdecl)]
            public static extern void All_Key_Blinking_x86(IntPtr handle, int DelayTime, int LoopTimes);

            [DllImport("talkfx-c.dll", EntryPoint = "All_Key_Blinking", CallingConvention = CallingConvention.Cdecl)]
            public static extern void All_Key_Blinking_x64(IntPtr handle, int DelayTime, int LoopTimes);
        }

        internal static class RyosMKFX
        {
            /* setting RGB on Ryos MK FX */
            [DllImport("talkfx-c-x86.dll", EntryPoint = "Set_all_LEDSFX", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_x86(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRGB, byte layout);

            [DllImport("talkfx-c.dll", EntryPoint = "Set_all_LEDSFX", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_x64(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRGB, byte layout);

            [DllImport("talkfx-c-x86.dll", EntryPoint = "Set_all_LEDSFX_struct", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_struct_x86(IntPtr handle, byte[] ucLEDOnOff, Color[] strctLEDRGB, byte layout);

            [DllImport("talkfx-c.dll", EntryPoint = "Set_all_LEDSFX_struct", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_struct_x64(IntPtr handle, byte[] ucLEDOnOff, Color[] strctLEDRGB, byte layout);

            [DllImport("talkfx-c-x86.dll", EntryPoint = "Set_all_LEDSFX_individual", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_individual_x86(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRed, byte[] ucLEDGreen, byte[] ucLEDBlue, byte layout);

            [DllImport("talkfx-c.dll", EntryPoint = "Set_all_LEDSFX_individual", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_individual_x64(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRed, byte[] ucLEDGreen, byte[] ucLEDBlue, byte layout);
        }
    }
}