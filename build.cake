#addin "wk.StartProcess"

using PS = StartProcess.Processor;

var version = "0.1.0";

Task("Compile").Does(() => {
    PS.StartProcess("mvn clean compile test-compile");
});

Task("Create-Jar")
    .IsDependentOn("Compile")
    .Does(() => {
        PS.StartProcess(@"mvn assembly:assembly -DdescriptorId=jar-with-dependencies");
});

Task("Run-Jar")
    .Does(() => {
        PS.StartProcess($@"java -Dfile.encoding=UTF-8 -jar target/aspose-service-{version}-jar-with-dependencies.jar 9090");
});

var target = Argument("target", "df");
RunTarget(target);