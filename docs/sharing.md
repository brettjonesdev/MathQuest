# Sharing your game

Your friends shouldn't need to install .NET to play. You can build a single file that runs on its own, then post it on GitHub for anyone to download.

## 1. Build a file that runs anywhere

```sh
dotnet publish src/MathQuest -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
```

- `-r` picks the platform. Use `win-x64` for Windows, `osx-arm64` for newer Macs, and `linux-x64` for Linux. ([platform list](https://learn.microsoft.com/en-us/dotnet/core/rid-catalog))
- `--self-contained` bundles .NET inside the file, so your friends don't need it. ([publishing overview](https://learn.microsoft.com/en-us/dotnet/core/deploying/))
- `PublishSingleFile` puts everything in one file. ([single-file apps](https://learn.microsoft.com/en-us/dotnet/core/deploying/single-file/overview))

The output lands in `src/MathQuest/bin/Release/net10.0/win-x64/publish/`, with your platform in place of `win-x64`. Run it yourself before you share it.

After Stage 4 renames the project, use `src/MathQuest.Cli` instead of `src/MathQuest`.

## 2. Post a release

A GitHub [release](glossary.md#release) is a download page attached to a [tag](glossary.md#tag). ([Managing releases](https://docs.github.com/en/repositories/releasing-projects-on-github/managing-releases-in-a-repository))

1. Push a tag, such as `stage-1-done`.
2. On your repository, go to **Releases → Draft a new release** and pick the tag.
3. Write what's new, as if your friends were reading it.
4. Attach one build for each platform.

Doing this by hand once or twice is fine. [Step 2.9](../stages/2-math-arena/README.md#29-robots-ship-your-game) automates it.

## 3. Tell your friends how to run it

Your game isn't signed by Apple or Microsoft, so their computers will warn them the first time they open it. Put these steps in your release notes:

- **Windows:** click **More info → Run anyway**. ([what SmartScreen is](https://support.microsoft.com/en-us/windows/security/windows-security/app-browser-control-in-the-windows-security-app))
- **Mac:** try to open it once, then go to **System Settings → Privacy & Security** and click **Open Anyway**. ([Apple's instructions](https://support.apple.com/en-us/102445))
- **Mac and Linux:** downloaded files lose permission to run, so first run `chmod +x MathQuest` in a terminal.

It's a console game, so it opens in a terminal window. That's expected.

## Stay safe

Your repository is public. Use a username or handle in the game credits and release notes, not your full name, school, or where you live.
