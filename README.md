# InstaPushLib

Examples

```c#
// Apps - List
var apps = new SOACat.InstaPushLib.Apps("https://api.instapush.im/v1/", "[User token]");
var list = apps.ListAsync();
apps.Wait();
...

```

```c#
// Apps - Add
var apps = new SOACat.InstaPushLib.Apps("https://api.instapush.im/v1/", "[User token]");
var add = apps.AddAsync(new AppAddRequest() { title = "TestExample" });
add.Wait();
...

```
