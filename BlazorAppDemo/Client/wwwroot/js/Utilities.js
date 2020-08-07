function myFunction(message) {
    console.log("From Utilities.js" + message)
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorAppDemo.Client", "GetCurrentCount")
        .then(result => {
            console.log("Count from JS " + result);
        })
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount")
}