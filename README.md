Power of aspnet for SPA 
========

## What is this?

Most notably, this includes **server-side prerendering**. You can build a "universal" (sometimes called "isomorphic") single-page application that renders its initial HTML on the server, and then continues execution on the client. Benefits:
 * Massively improves application delivery and startup time (often reducing from 5-10+ seconds to 100ms or so, especially on high-latency networks or low-CPU-speed clients)
 * Enables search engine crawlers to explore your SPA
 * Ensures that users don't wait for any 'loading' UI when they first hit your application.

## Trying the samples

To get started,

1. Ensure you have [installed the latest stable version of .NET Core](https://www.microsoft.com/net). The packages are built to work with .NET Core version RC1. [Installers](https://www.microsoft.com/net/download) are available for **Windows**, **OS X**, **Linux**.
2. Ensure you have [installed a recent version of Node.js](https://nodejs.org/en/). To check this works, open a console prompt, and type `node -v`. It should print a version number.
3. Clone this repository:

   ```
   git clone https://github.com/laskoviymishka/conf-sample.git
   ```

**Using Visual Studio on Windows**

1. Open the solution file, `JSServiceSamples.sln`, in Visual Studio or just a folder with your favorite editor.
2. Wait for it to finish fetching and installing dependencies.
3. If you get the error `'reactivex/rxjs' is not in the npm registry`, then your Visual Studio installation's version of the NPM tool is out of date. You will need to restore NPM dependencies manually from a command prompt (e.g., `cd 0-basic-spa` then `npm install`).
4. Select a sample and run it. 

**Using dotnet on Windows/Mac/Linux**

1. In the solution root directory (`NodeServices` - i.e., the directory that contains `NodeServices.sln`), restore the .NET dependencies:

   ```
   dnx restore
   ```

2. Change directory to whichever sample you want to run, then restore the Node dependencies. For example:

   ```
   cd *sample name*
   npm install
   ```

3. Where applicable, build the project. For example, the Angular example uses Gulp, so you'll need to execute `gulp`, whereas the React example uses Webpack, so you'll need to execute `webpack`. The ES2015 example does not need to be built.

   If you don't already have it, install the applicable build tool first (e.g., `npm install -g webpack`).

4. Run the project (and wait until it displays the message `Application started`)

  ```
  dnx web
  ```

5. Browse to [`http://localhost:5000/`](http://localhost:5000/)
