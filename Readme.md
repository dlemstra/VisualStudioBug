# VisualStudioBug

This project demonstrates a bug in:

```
Microsoft Visual Studio Enterprise 2017 RC
Version 15.0.26206.0 D15REL
```

## Steps to reproduce:

* Open VisualStudioBug.sln
* Compile project
* Open VisualStudio.cs
* Select 'VisualStudioBug(net45)' in dropdown
* Change Bug to IBug and keep the cursor there
* Quick Actions => Generate type 'IBug' => Generate interface 'IBug' in new file.
* Press F12 (Go To Definition)

This will result in the following exception:

```
Object reference not set to an instance of an object.
```