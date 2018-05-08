# Mandycan

Mandycan is an ASP.NET Core project generator. It's goal is to minimize writing boilerplate code so that you can get to work faster.

## How do I use it?

MAKE SURE YOU <code>git clone</code> the repository.

If you're on windows run <code>windows.bat</code>
If you're on Ubuntu/Linux run <code>./ubuntu.sh</code>
If you're on Mac run <code>./mac.sh</code>

This will build an OS-specific executable in: <code>bin/Release/netcoreapp2.0/yourOS-x64</code>

<code>cd</code> into this folder and allow execution permission if you're on Mac or Linux: <code>chmod +x mandycan</code>

Type <code>pwd</code> on Mac/Linux or <code>chdir</code> on Windows. Copy the directory it outputs.

Windows Setup:

* Press the windows key.
* Type <code>env</code> and press enter.
* Goto "Environment Variables..."
* Goto "Path" and "New".
* Paste the output you previously copied.
* Press Ok on all the checkboxes.
* Open a NEW cmd prompt and type <code>mandycan new yourAppNameHere</code>

Linux Setup:

* type <code>cd</code> into a terminal and press enter. You're now in your home folder for the current user account.
* Open your <code>.bashrc</code> file. Its located in the folder you're currently in.
* Add this line and edit it to reflect where you've installed mandycan: <code>alias mandycan="/Users/yourName/mandycan/bin/Release/netcoreapp2.0/ubuntu.16.10-x64/mandycan"</code>
* Save and close <code>.bashrc</code> followed by this command: <code>source .bashrc</code>
* Open a new terminal and type <code>mandycan new yourAppNameHere</code>

Mac Setup:

* Same as Linux, except edit <code>.bash_profile</code> instead of <code>.bashrc</code>

## Isnt this the same thing as CandyMan?

Yes and No. It emulates the same structure that candyman does, but is written in C# and will soon offer you the ability to create controllers, models, views and more as opposed to just generating a project.

## Features

Currently, Mandycan features generating a Full MVC project via:

<code>mandycan new yourProjectName</code>

To use the below commands, ensure you've already created a project via <code>mandycan new yourProjectName</code> and that you've <code>cd'd</code> into this folder.

<code>mandycan mvc User</code> - Generates a Model, View and Controller all at once.
<code>mandycan model Animal</code> - Generates a basic Model, with commonly used annotations.
<code>mandycan controller Product</code> - Generates a basic controller.
