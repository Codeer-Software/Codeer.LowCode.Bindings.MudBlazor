const AssemblyName = "Codeer.LowCode.Bindings.MudBlazor";

/**
 *
 * @param {string} src
 * @param {string | undefined} type
 * @returns {void}
 */
function installScript(src, type) {
  const script = document.createElement("script");
  script.setAttribute("src", src);
  if (type) {
    script.setAttribute("type", type);
  }
  document.body.appendChild(script);
}

/**
 *
 * @param {string} src
 * @returns {void}
 */
function installCss(src) {
  const link = document.createElement("link");
  link.setAttribute("rel", "stylesheet");
  link.setAttribute("href", src);
  document.head.appendChild(link);
}

function startup() {
  if(document.head.querySelector(`meta[name="${AssemblyName}::autoload"]`)?.content === "false"){
    return;
  }
  
  installCss("_content/MudBlazor/MudBlazor.min.css");
  installCss("_content/Heron.MudCalendar/Heron.MudCalendar.min.css");
  installScript("_content/MudBlazor/MudBlazor.min.js");
  installScript("_content/Heron.MudCalendar/Heron.MudCalendar.min.js", "module");
}

export function beforeStart() {
  startup();
}

export function beforeWebStart() {
  startup();
}
