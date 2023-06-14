# 添加配置

使用 ts-node 运行和调试 TypeScript 文件

打开您要调试的 TypeScript 文件。

在文件中添加断点。

点击左侧的调试按钮，然后选择 Debug with ts-node。

点击绿色的“启动调试”按钮，以运行和调试 TypeScript 文件。

现在，您应该能够在 VS Code 中使用 ts-node 运行和调试 TypeScript 文件。注意，这种方法需要在项目中安装 ts-node 模块。

```json
{
  "version": "0.2.0",
  "configurations": [
    {
      "name": "Debug with ts-node",
      "type": "node",
      "request": "launch",
      "args": ["${relativeFile}"],
      "runtimeArgs": ["-r", "ts-node/register"],
      "cwd": "${workspaceFolder}",
      "internalConsoleOptions": "neverOpen",
      "sourceMaps": true
    }
  ]
}
```

```bash
pnpm add -D typescript
pnpm add -D ts-node
pnpm add -D tslib @types/node

pnpm config set registry https://registry.npm.taobao.org
pnpm config set registry https://registry.npmjs.org
```
