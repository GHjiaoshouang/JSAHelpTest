## JSAHelp�������(C# )

## ˵����

---

```markdown
	Oooops!Simple, simple-to-call approach, integration of multiple platforms, multiple environments!
	This is an ASP.NET help class written in C#,which organized a lot of open source code��a lot of good authors and source code are referenced.
	The original purpose is to collect the various problems that have been encountered in development, and organize them into knowledge base, which can facilitate the development and learning of the future.
	The main functions of this help library are: File processing, log system, form transition, JSON, XML, parse, circuit breakers, retry mechanism, ZIP compression/decompression, Winform beautification, multi-thread calls, add and delete registry, mainstream database to add and delete, thread the fuse/kill, batch command/command-line execution, HTTP, string formatting, sentenced to services and service request Break, MD5, AES, DES, RSA, BASE64 and other encryption algorithms and other practical functions.
	The class library supports multiple versions (.net Framework 4.5~4.8/.NET5.0~6.0/.NET Core 3.1/.NET Standard2.0~2.1).
    To prevent code abuse, the library has its own signature verification mechanism, and the code needs to run on the signed machine.Future will continue to fill in various useful help library.
    The signing machine  download please email:1924038917jsa@gmail.com or attention:https://github.com/GHjiaoshouang.
	If there is infringement please contact me.
	Thanks.
```

```bash
`�򵥵ġ�ɵ��ʽ�ĵ��÷�ʽ�����ɶ�ƽ̨���໷��!
`���ǻ���C#���Կ�����ASP.NET�����⣬���������˺ܶ࿪Դ�Ĵ��룬����˺ܶ��������ߵĴ��롣���Ŀ���������Ѽ��Լ��ڿ������������ĸ������⣬�����֪ʶ�⣬�����Ժ�Ŀ�����ѧϰ����Ҫ�Ĺ����У��ļ�������־ϵͳ�����ת����JSON������XML��������·���ơ����Ի��ơ�ZIPѹ��/��ѹ����Winform���������̵߳��á�ע�����ɾ�Ĳ顢�������ݿ���ɾ�Ĳ顢�߳��۶�/ǿɱ��������/������ִ�С�HTTP���񼰷��������ַ�����ʽ�����жϡ�MD5/AES/DES/RSA/BASE64�ȶ��ּ����㷨�ȶ���ʵ�ù��ܡ����֧�ֶ���汾(.NET Framework 4.5~4.8/.NET5.0~6.0/.NET Core 3.1/.NET Standard2.0~2.1)��
`���ʹ�ù������������⣬�����ڡ�https://github.com/GHjiaoshouang/JSAHelpTest.git���鿴����ĵ��ú�ʹ�÷�ʽ��
`Ϊ�˷�ֹ�������ã��������ר����ǩ����֤���ƣ�����������Ҫ���ѱ�ǩ���Ļ����ϡ����ڻ᲻��������������ʵ�ð�����⡣ǩ������עGitHub:[https://github.com/GHjiaoshouang]��������Ȩ����ϵ�ҡ�
`лл��
```

------

## ʹ�ã�

��־ϵͳ������Ĭ�ϵģ����򱻵��þͻ������־����־��λ���ǿ������õģ�

```c#
JSAHelpEN.toolsFactory.Logger.InitializationSetting.logPath = JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramDebug;
```

���ö��·������ѡ��

�����쳣��Ĭ�ϲ���չʾ�쳣��ֻ��д����������־System Logs���棬������׳������쳣����Ҫ���ã�

```c#
 JSAHelpEN.toolsFactory.isReturnExceptionMessage = true;
```

�����������п�ѡ����isStrongLoggerRecord��Ĭ��false�����Ҫ����ĳ��������¼������־����������������:

```c#
JSAHelpEN.toolsFactory.Logger.InitializationSetting.isOpenRunningProgramLogger = true;
```



���з������о���ĵ���ʾ���;���˵����������WinForm��ʼ����ȫ�Ǿ�̬����������ʵ�������á�

```c#
JSAHelpEN.toolsFactory.XXX	//����,ʾ�����£�
```

![](http://home.ddns.cm:40908/down/image-20220724235027795.png)