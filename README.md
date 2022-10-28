## open UPM + url https://github.com/HeNuoLibrary/WebGLPlugins.git#upm 

## 此包包括 

#### 1.WebGL获取网页连接附加的参数

#### 2.WebGL不显示中文

#### 3.WebGL不能输入中文

#### 4.tab键切换聚焦输入框

更多问题请查看https://github.com/kou-yeung/WebGLInput

# 注意

#### 由于unity版本不同  或者使用的 WebGLTemplates 不同 发布之后 

需要保证 index.html中的

```html
<div id="unity-container" class="unity-desktop">
```

与WebGLInput 中WebGLInput.CanvasId 保持一致

```csharp
        static WebGLInput()
        {
#if UNITY_2020_1_OR_NEWER
            WebGLInput.CanvasId = "unity-container";
#elif UNITY_2019_1_OR_NEWER
            WebGLInput.CanvasId = "unityContainer";
#else
            WebGLInput.CanvasId = "gameContainer";
#endif
            WebGLInputPlugin.WebGLInputInit();
        }
```
