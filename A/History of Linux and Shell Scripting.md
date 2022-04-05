History of Linux and Shell Scripting
===
The term Linux often brings to mind the Operating System. In reality, 'Linux' is only the kernel. When Linus Torvolds announced to the Usenet newsgroup in 1991, that he was working on a 'free', multi-threaded Operating System, I don't even think he himself invisioned the explosive adoption of his project. It was meant to be small. Here's where it all began:

>Hello everybody out there using minix - I'm doing a (free) operating system (just a hobby, won't be big and professional like gnu) for 386(486) AT clones. This has been brewing since april, and is starting to get ready. I'd like any feedback on things people like/dislike in minix, as my OS resembles it somewhat (same physical layout of the file-system (due to practical reasons) among other things). I've currently ported bash(1.08) and gcc(1.40), and things seem to work. This implies that I'll get something practical within a few months, and I'd like to know what features most people would want. Any suggestions are welcome, but I won't promise I'll implement them :-) Linus (torvalds [at] kruuna.helsinki.fi) PS. Yes – it's free of any minix code, and it has a multi-threaded fs. It is NOT portable (uses 386 task switching etc), and it probably never will support anything other than AT-harddisks, as that's all I have :-(. —Linus Torvalds

This was a personal project for Torvolds. 

Prior to this announcement, there were events that lead up to the creation of Linux as we know it today.

- AT&T Bell Laboratories released the Unix Operating system in 1970

- Richard Stallman started the GNU project in 1983

- Intel released the first x86 Mircroprocessor in 1985

- Andew S Tanenbaum released the MINIX OS in 1987


Today, Linux is published under the GNU GPL License. This License allows its users to develop and work on the Linux project, making it their own. The latest GPL release is GPLv3, but Torvolds is against its adoption.

Today, the Linux kernel is in many software and hardware projects.

- Cadillac XTS (2013)
- High-tech traffic control systems
- Lockeed Martin's nuclear submarine
- CCTV systems
- Smart Home appliances
- Sony Playstation

This list is far from exaustive. 

I hope that you can appreciate how many devices and software solutions that are available for use that run Linux. Imagine what the world would be like without it.


Getting started with Shell Programming
===
The first thing to know about shell programming, is that shell programs are `interpreted` everytime they run.

## What is a shell program

In its most basic form, a shell program is one or more shell commands.
For example, 


```
cd home && ls -l

```
This simple program traverses into the directory called 'home' and then lists the contents of that directory showing in long listing format.  The glue for this program is `&&`. This says 

> and while you are at it shell...do something else for me

That's one way you can run a shell program. The more common way is using a file with a `.sh` extention. Though honestly, you really don't need the extention, you can just add the `interpreted` script line at the top of the file: 

`#!/usr/bin/env bash`
This line is a common idiom used by the shell to interpret a bash script.

Though if you did use the shell scripting syntax it would look like:

`#!/usr/bin/env sh`

The hash and exclaimation are known as `shebang`. (I don't know why)

For example, you can run the HelloWorld program as follows. Assume the starter line is included and the following code is inside a file named
`helloworld`

```
echo "Hello World";

```
That's it. That is the whole program. To execute it, you must either make the file executable or prefix the command `bash` with a space and then the filename. 

`bash helloworld` 


The Shell Variables and Environment
===
What is a `shell`? At the core, it is a `macro processor` with the ability to execute commands. For example, if a user wanted to see contents of a specific directory, they would first issue the GNU utility command `cd` followed by the name of the directory. This command, once executed, places the user *inside* the target directory.

The process goes as this:
- issue the `cd` command
- the macro processor creates an [execution context]('https://www.gnu.org/software/bash/manual/html_node/Command-Execution-Environment.html')
or environment.


- a `system call` known as `fork()` executes

- while fork() is executing the system `waits` for the command to execute via another function `exec()`

- once that shell finishes execution, it is terminated and the memory is cleared

That may be an over-simplified description.

- A more [detailed]('https://www.gnu.org/software/bash/manual/html_node/Shell-Operation.html') description. 

The entire process is known as `fork-and-exec`.

The Unix `shell` is also a programming language. The programming language part is actually a combination of the `interpreter` and the built-in GNU utility commands.


## Variables
There are over 100 shell parameters and variables.
One of the most common shell variables is the built-in `cd` command.
This command maps to the `CDPATH` variable.

What about the prompt we see after opening a shell? It may look like this:

`developer@DESKTOP-I2F96GD ~/Downloads`

This is known as a prompt string. The real value is actually much uglier:

`\[\e]0;\w\a\]\n\[\e[32m\]\u@\h \[\e[33m\]\w\[\e[0m\]\n\$`

Both of these formats are known as the `PS1` variable.
-   \w = working directory
- \u = username
- \h = hostname
- \n = newline
- \$ = is the bash shell symbol (bourn again shell)

To see what your prompt string looks like do:
```
echo $PS1
```
in your shell environment.

Those commands are great. Suppose you wanted to get a list of *all* the commands that you ran within a day? There's a built-in command for that also, `history`.  You can even clear the history list by passing an option after the command `-c`. 

## Environment
So, what about the shell [environment]('https://www.gnu.org/software/bash/manual/html_node/Environment.html') ? How does it relate to commands?

Well, it turns out that the shell can *scan* its own environment and can even create a parameter for any familiar names that it finds *within* its environment. The commands `inherit` the shell environment.






Training link: https://revature.zoom.us/j/99972266541?



pwd = ZGxKeTQwNjFCem8vdW1tWHhEZUQ0QT09


ZGxKeTQwNjFCem8vdW1tWHhEZUQ0QT09