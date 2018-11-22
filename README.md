# nondeterministic-impressionism
Algorithm that uses .NET graphics library and pseudo-randomness to produce an image based on a reference that appears like a drawn version of the original. Comparisons are made after each stroke, and if the stroke has made the image more different from the reference than the previous state, it is reverted.

Written in C# in the Visual Studio Community 2017 IDE. All source code in Nondeterministic Impressionism/Form1.cs

Here is an example reference image and drawing produced with sampling mode, stroke drawing mode, and colour matching.

## Reference:
![Reference](https://i.imgur.com/g46SahS.png)

## Drawing:
https://i.imgur.com/NtLaH4o.png
