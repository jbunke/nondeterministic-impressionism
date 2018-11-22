# nondeterministic-impressionism
Algorithm that uses .NET graphics library and pseudo-randomness to produce an image based on a reference that appears like a drawn version of the original. Comparisons are made after each stroke, and if the stroke has made the image more different from the reference than the previous state, it is reverted.
