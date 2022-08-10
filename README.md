## JSAHelp帮助类库(C# )

## 说明：

---

```markdown
	Oooops!Simple, simple-to-call approach, integration of multiple platforms, multiple environments!
	This is an ASP.NET help class written in C#,which organized a lot of open source code，a lot of good authors and source code are referenced.
	The original purpose is to collect the various problems that have been encountered in development, and organize them into knowledge base, which can facilitate the development and learning of the future.
	The main functions of this help library are: File processing, log system, form transition, JSON, XML, parse, circuit breakers, retry mechanism, ZIP compression/decompression, Winform beautification, multi-thread calls, add and delete registry, mainstream database to add and delete, thread the fuse/kill, batch command/command-line execution, HTTP, string formatting, sentenced to services and service request Break, MD5, AES, DES, RSA, BASE64 and other encryption algorithms and other practical functions.
	The class library supports multiple versions (.net Framework 4.5~4.8/.NET5.0~6.0/.NET Core 3.1/.NET Standard2.0~2.1).
    To prevent code abuse, the library has its own signature verification mechanism, and the code needs to run on the signed machine.Future will continue to fill in various useful help library.
    The signing machine  download please email:1924038917jsa@gmail.com or attention:https://github.com/GHjiaoshouang.
	If there is infringement please contact me.
	Thanks.
```

```bash
`简单的、傻瓜式的调用方式，集成多平台、多环境!
`这是基于C#语言开发的ASP.NET帮助库，里面整理了很多开源的代码，借鉴了很多优秀作者的代码。最初目的是用于搜集自己在开发当中遇到的各种问题，整理成知识库，便于以后的开发和学习。主要的功能有：文件处理、日志系统、表格转换、JSON解析、XML解析、断路机制、重试机制、ZIP压缩/解压缩、Winform美化、多线程调用、注册表增删改查、主流数据库增删改查、线程熔断/强杀、批命令/命令行执行、HTTP服务及服务请求、字符串格式化、判断、MD5/AES/DES/RSA/BASE64等多种加密算法等多种实用功能。类库支持多个版本(.NET Framework 4.5~4.8/.NET5.0~6.0/.NET Core 3.1/.NET Standard2.0~2.1)。
`如果使用过程中遇到问题，可以在【https://github.com/GHjiaoshouang/JSAHelpTest.git】查看具体的调用和使用方式。
`为了防止代码滥用，类库设有专属的签名验证机制，代码运行需要在已被签名的机器上。后期会不断向里面填充各类实用帮助类库。签名器关注GitHub:[https://github.com/GHjiaoshouang]。如有侵权请联系我。
`谢谢。
```

------

## 使用：

日志系统开启是默认的，程序被调用就会产生日志，日志的位置是可以配置的：

```c#
JSAHelpEN.toolsFactory.Logger.InitializationSetting.logPath = JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramDebug;
```

多个枚举路径可以选择。

调用异常后默认不会展示异常，只会写入程序调用日志System Logs里面，如果想抛出具体异常，需要配置：

```c#
 JSAHelpEN.toolsFactory.isReturnExceptionMessage = true;
```

多数方法都有可选参数isStrongLoggerRecord，默认false，如果要屏蔽某个方法记录运行日志，可以在这里配置:

```c#
JSAHelpEN.toolsFactory.Logger.InitializationSetting.isOpenRunningProgramLogger = true;
```



所有方法都有具体的调用示例和具体说明，方法除WinForm初始化外全是静态方法，无须实例化调用。

```c#
JSAHelpEN.toolsFactory.XXX	//调用,示例如下：
```

![](http://home.ddns.cm:40908/down/image-20220724235027795.png)