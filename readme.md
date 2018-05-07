# Mandycan

Mandycan is an ASP.NET Core project generator. It's goal is to minimize writing boilerplate code so that you can get to work faster.

## How do I use it?

Currently, Mandycan only supports 64bit windows 10 and 64bit Ubuntu 16.04. If you're running Windows, run <code>windows.bat</code>. If you're running Ubuntu 16.04, run <code>./ubuntu.sh</code>. This will build a binary targeting your specific OS. Enter the <code>bin/Release/netcoreapp2.0</code> folder followed by either the <code>win10-x64</code> or <code>ubuntu.16.10-x64</code> folder. From here, set a path variable pointing to this directory if you're on windows. If you're on Ubuntu, do the same but make an alias in your <code>.bashrc</code>

## Isnt this the same thing as CandyMan?

Yes and No. It emulates the same structure that candyman does, but is written in C# and will soon offer you the ability to create controllers, models, views and more as opposed to just generating a project.

## Features

Currently, Mandycan features generating a Full MVC project via:

<code>mandycan new yourProjectName</code>

It also supports generating a Controller and a View associated with it via:

<code>mandycan mvc yourControllerName</code>

To use the <code>mvc</code> command, ensure that you are inside of your project directory.
