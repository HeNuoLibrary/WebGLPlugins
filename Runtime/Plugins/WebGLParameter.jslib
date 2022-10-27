// 获取URL参数
//原文链接：https://blog.csdn.net/xunideshijie/article/details/123795652

var WebGLParameter = {
      
    StringReturnValueFunction: function()
    {
        var returnStr = window.location.search;
        var buffer = _malloc(lengthBytesUTF8(returnStr) + 1);
        writeStringToMemory(returnStr, buffer);
        return buffer;
    } 
};

mergeInto(LibraryManager.library,WebGLParameter);