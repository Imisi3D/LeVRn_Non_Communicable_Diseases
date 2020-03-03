#! /bin/sh

# Download Unity3D installer into the container

#  Refer to https://unity3d.com/get-unity/download/archive and find the link pointed to by Mac "Unity Editor"
echo 'Downloading Unity 2019.1.2 pkg:'
curl --retry 5 -o Unity.pkg https://download.unity3d.com/download_unity/3e18427e571f/MacEditorInstaller/Unity.pkg
if [ $? -ne 0 ]; then { echo "Download failed"; exit $?; } fi

# By default, only Mac OSX support is included in the original editor package; Windows, Linux, iOS, Android, and others are separate

# We download Windows support
echo 'Downloading Unity 2019.1.2 Windows Build Support pkg:'
curl --retry 5 -o Unity_win.pkg https://download.unity3d.com/download_unity/3e18427e571f/MacEditorTargetInstaller/UnitySetup-Windows-Mono-Support-for-Editor-2019.1.2f1.pkg
if [ $? -ne 0 ]; then { echo "Download failed"; exit $?; } fi

# Run installer(s)
echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity.pkg -target /
echo 'Installing Unity_win.pkg'
sudo installer -dumplog -package Unity_win.pkg -target /
