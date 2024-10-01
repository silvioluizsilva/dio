exports.id = 790;
exports.ids = [790];
exports.modules = {

/***/ 3351:
/***/ ((module) => {

// Exports
module.exports = {
	"colorBackground": "Layout_colorBackground__Adyt4",
	"colorBackgroundBottom": "Layout_colorBackgroundBottom__9Yf_q"
};


/***/ }),

/***/ 7410:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Z": () => (/* binding */ ArrowIcon)
/* harmony export */ });
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(997);
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__);

function ArrowIcon({ className , color ="text-primary"  }) {
    return /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("svg", {
        xmlns: "http://www.w3.org/2000/svg",
        width: "24",
        height: "24",
        fill: "none",
        viewBox: "0 0 24 24",
        className: className,
        children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("path", {
            className: `stroke-current ${color}`,
            strokeLinecap: "round",
            strokeLinejoin: "round",
            strokeWidth: "2",
            d: "M5 12h14M12 19l7-7-7-7"
        })
    });
};


/***/ }),

/***/ 3193:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Z": () => (/* binding */ Footer)
/* harmony export */ });
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(997);
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__);

const sunIcon = /*#__PURE__*/ (0,react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxs)("svg", {
    xmlns: "http://www.w3.org/2000/svg",
    width: "25",
    height: "24",
    fill: "none",
    viewBox: "0 0 25 24",
    className: "dark:opacity-50",
    children: [
        /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("g", {
            stroke: "#fff",
            strokeLinecap: "round",
            strokeLinejoin: "round",
            strokeWidth: "2",
            clipPath: "url(#clip0_192_823)",
            children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("path", {
                d: "M12.5 17a5 5 0 100-10 5 5 0 000 10zM12.5 1v2M12.5 21v2M4.72 4.22l1.42 1.42M18.86 18.36l1.42 1.42M1.5 12h2M21.5 12h2M4.72 19.78l1.42-1.42M18.86 5.64l1.42-1.42"
            })
        }),
        /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("defs", {
            children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("clipPath", {
                id: "clip0_192_823",
                children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("path", {
                    className: "fill-current text-white",
                    d: "M0 0H24V24H0z",
                    transform: "translate(.5)"
                })
            })
        })
    ]
});
const moonIcon = /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("svg", {
    xmlns: "http://www.w3.org/2000/svg",
    width: "21",
    height: "20",
    fill: "none",
    viewBox: "0 0 21 20",
    children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("path", {
        stroke: "#fff",
        strokeLinecap: "round",
        strokeLinejoin: "round",
        strokeWidth: "2",
        className: "stroke-current text-gray-400 dark:text-white",
        d: "M19.5 10.79A9 9 0 119.71 1a7 7 0 009.79 9.79v0z"
    })
});
const ThemeSwitcher = ()=>{
    return /*#__PURE__*/ (0,react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxs)("div", {
        className: "flex mt-6 bg-white justify-center dark:bg-gray-900 rounded-3xl p-1",
        children: [
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("button", {
                type: "button",
                "aria-label": "Use Dark Mode",
                onClick: ()=>{
                    document.documentElement.classList.add("dark");
                    localStorage.setItem("theme", "dark");
                },
                className: "flex items-center h-full pr-2 dark:bg-primary rounded-3xl flex justify-center align-center p-2 w-24 h-10 transition",
                children: moonIcon
            }),
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("button", {
                type: "button",
                "aria-label": "Use Light Mode",
                onClick: ()=>{
                    document.documentElement.classList.remove("dark");
                    localStorage.setItem("theme", "light");
                },
                className: "flex items-center h-full pr-2 bg-primary dark:bg-transparent rounded-3xl flex justify-center align-center p-2 w-24 h-10 transition",
                children: sunIcon
            })
        ]
    });
};
function Footer({ copyrightText  }) {
    return /*#__PURE__*/ (0,react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxs)("footer", {
        className: "py-16 flex flex-col items-center",
        children: [
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("p", {
                className: "dark:text-white uppercase mb-3 font-bold opacity-60",
                children: copyrightText
            }),
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx(ThemeSwitcher, {})
        ]
    });
};


/***/ }),

/***/ 7673:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Z": () => (/* binding */ Header)
/* harmony export */ });
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(997);
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_link__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(1664);
/* harmony import */ var next_link__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_link__WEBPACK_IMPORTED_MODULE_1__);


function Header({ name  }) {
    return /*#__PURE__*/ (0,react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxs)("header", {
        className: "pt-20 pb-12",
        children: [
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("div", {
                className: "w-12 h-12 rounded-full block mx-auto mb-4 bg-gradient-conic from-gradient-3 to-gradient-4"
            }),
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("p", {
                className: "text-2xl dark:text-white text-center",
                children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx((next_link__WEBPACK_IMPORTED_MODULE_1___default()), {
                    href: "/",
                    children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("a", {
                        children: name
                    })
                })
            })
        ]
    });
};


/***/ }),

/***/ 1641:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Z": () => (/* binding */ Layout),
/* harmony export */   "d": () => (/* binding */ GradientBackground)
/* harmony export */ });
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(997);
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var classnames__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(9003);
/* harmony import */ var classnames__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(classnames__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(6689);
/* harmony import */ var react__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(react__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _Layout_module_css__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(3351);
/* harmony import */ var _Layout_module_css__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_Layout_module_css__WEBPACK_IMPORTED_MODULE_3__);




function GradientBackground({ variant , className  }) {
    const classes = classnames__WEBPACK_IMPORTED_MODULE_1___default()({
        [(_Layout_module_css__WEBPACK_IMPORTED_MODULE_3___default().colorBackground)]: variant === "large",
        [(_Layout_module_css__WEBPACK_IMPORTED_MODULE_3___default().colorBackgroundBottom)]: variant === "small"
    }, className);
    return /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("div", {
        className: classes
    });
}
function Layout({ children  }) {
    const setAppTheme = ()=>{
        const darkMode = localStorage.getItem("theme") === "dark";
        const lightMode = localStorage.getItem("theme") === "light";
        if (darkMode) {
            document.documentElement.classList.add("dark");
        } else if (lightMode) {
            document.documentElement.classList.remove("dark");
        }
        return;
    };
    const handleSystemThemeChange = ()=>{
        var darkQuery = window.matchMedia("(prefers-color-scheme: dark)");
        darkQuery.onchange = (e)=>{
            if (e.matches) {
                document.documentElement.classList.add("dark");
                localStorage.setItem("theme", "dark");
            } else {
                document.documentElement.classList.remove("dark");
                localStorage.setItem("theme", "light");
            }
        };
    };
    (0,react__WEBPACK_IMPORTED_MODULE_2__.useEffect)(()=>{
        setAppTheme();
    }, []);
    (0,react__WEBPACK_IMPORTED_MODULE_2__.useEffect)(()=>{
        handleSystemThemeChange();
    }, []);
    return /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("div", {
        className: "relative pb-24 overflow-hidden",
        children: /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("div", {
            className: "flex flex-col items-center max-w-2xl w-full mx-auto",
            children: children
        })
    });
};


/***/ }),

/***/ 8590:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Z": () => (/* binding */ SEO)
/* harmony export */ });
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(997);
/* harmony import */ var react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var next_head__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(968);
/* harmony import */ var next_head__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(next_head__WEBPACK_IMPORTED_MODULE_1__);


function SEO({ title , description  }) {
    return /*#__PURE__*/ (0,react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsxs)((next_head__WEBPACK_IMPORTED_MODULE_1___default()), {
        children: [
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("title", {
                children: title
            }),
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("meta", {
                name: "description",
                content: description
            }),
            /*#__PURE__*/ react_jsx_runtime__WEBPACK_IMPORTED_MODULE_0__.jsx("meta", {
                property: "og:title",
                content: title
            })
        ]
    });
};


/***/ }),

/***/ 3395:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "r": () => (/* binding */ getGlobalData)
/* harmony export */ });
const getGlobalData = ()=>{
    const name = process.env.BLOG_NAME ? decodeURI(process.env.BLOG_NAME) : "DIO Blog";
    const blogTitle = process.env.BLOG_TITLE ? decodeURI(process.env.BLOG_TITLE) : "Blog em NextJS";
    const footerText = process.env.BLOG_FOOTER_TEXT ? decodeURI(process.env.BLOG_FOOTER_TEXT) : "All rights reserved.";
    return {
        name,
        blogTitle,
        footerText
    };
};


/***/ }),

/***/ 9361:
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";

// EXPORTS
__webpack_require__.d(__webpack_exports__, {
  "z": () => (/* binding */ getPostBySlug),
  "J": () => (/* binding */ getPosts)
});

// EXTERNAL MODULE: external "axios"
var external_axios_ = __webpack_require__(2167);
var external_axios_default = /*#__PURE__*/__webpack_require__.n(external_axios_);
;// CONCATENATED MODULE: ./services/api.js

const api = external_axios_default().create({
    baseURL: "https://ycdisbgqlbcsuzfttdvp.supabase.co/rest/v1/",
    headers: {
        apikey: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InljZGlzYmdxbGJjc3V6ZnR0ZHZwIiwicm9sZSI6ImFub24iLCJpYXQiOjE3Mjc3OTI2MTgsImV4cCI6MjA0MzM2ODYxOH0.FaCEWpPetuJqHg0T7OMJ8N-uwn2dU3GSK0gjGxCq4Go",
        authorization: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InljZGlzYmdxbGJjc3V6ZnR0ZHZwIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTcyNzc5MjYxOCwiZXhwIjoyMDQzMzY4NjE4fQ.XjTeu92JW0rcWJEQlSlSSud0TC-hZQo5KQjFZR1zEoA"
    }
});

;// CONCATENATED MODULE: ./utils/mdx-utils.js

const getPosts = async ()=>{
    const { data  } = await api.get("/posts");
    if (data) {
        return data;
    }
    return [];
};
const getPostBySlug = async (id)=>{
    //TODO: BUSCAR UM POST EM ESPECIFICO.
    const { data  } = await api.get(`/post?id=eq.${id}`);
    console.log(data);
    if (data) {
        return data;
    }
    return {};
};


/***/ })

};
;