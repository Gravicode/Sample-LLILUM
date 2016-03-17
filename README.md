# Sample-LLILUM
This is demo project, to test LLILUM on Nucleo STM32F401 or another Cortex-M board compatible.

Info Dikit tetang Llilum
-------------------------
#Zelig (compiletime, debugtime support)
#The LlilumSDK (basically an install wrapper for the llvm toolchain components)
#A Visual Studio dir containing a couple vsix extensions for Visual Studio to add new project templates and build/deploy integration
#an mbed-based hardware abstraction
#LLVM compiler (external component)
#GCC ARM toolchain (external component)

Step untuk prepare LLilum:
https://github.com/NETMF/llilum/wiki/setup

Download SDK, plugin LLilum untuk VS dari sini:
https://www.dropbox.com/sh/ayz01fkclym5a1r/AAAEsaNlaV-OeuT--OhP8r9Ba?dl=0

Ngakalin Debug Llilum dengan Visual Studio
1) download openocd dan kopi ke 2 folder di path-nya zelig dan sdk llilum : https://github.com/NETMF/llilum/wiki/Open-OCD-and-STM32-Board-Usage
2) download pskill dari https://technet.microsoft.com/en-us/sysinternals/pskill.aspx kemudian rename pskill.exe jadi kill.exe, taruh di Environment PATH-nya windows
3) Set debuger ke OpenOCD (Native project -> Properties -> Debugging)
4) Buka project terus jalankan debug di VS, teken F5
5) setelah deployment sukses, jalankan file 'debugSTM32F401.bat' dari cmd, jangan tekan apa2 setelah itu, karena kita pengen openocd dijalankan kembali setelah di kill oleh VS.
6) Debug session harusnya sudah bisa berjalan, tekan pause di VS, taruh breakpoint terus lanjut lagi (teken continue).
