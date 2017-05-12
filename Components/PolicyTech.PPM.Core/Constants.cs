using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection; //Used for FieldInfo
using System.Text.RegularExpressions;
using System.Web;

namespace PolicyTech.PPM.Core {
	[TypeScriptModule("Constants")]
	public static class Constants {
		private const char m_groupSeparator = (Char) 29;
		private const char m_unitSeparator = (Char) 31;
		private const char m_recordSeparator = (Char) 30;
		private static string m_ProductID = "2";
		private static string m_ProductMajorVersion = "9";
		private static string m_ProductMinorVersion = "600";
		private static string m_ProductVersionRevision = "@DEV_NOT_FOR_RELEASE@";
		private static string m_ProductVersionDate = "@DEV_RELEASE_DATE@";
		private static string m_CurrentDBSchemaVersion = "9.600.07";
		private static string m_CurrentDataFolderVersion = "8.500.01";
		private static string m_DefaultWorkflowVersion = "9.2.0";
		private static string m_DraftWorkflowVersion = "7.0.0";
		private static string m_SystemWorkflowVersion = "9.2.0";
		private static string m_ContractWorkflowVersion = "7.0.0";
		private static string m_MetaDataVersionNumber = "9.1.1";
		private static string m_EncryptKey = "imaginpro";
		private static string m_EncryptKeyTempFiles = "@RkW3!&QLN";
		private static string m_ProductName = "PolicyTech<SUP><FONT SIZE=\"-1\">&reg;</FONT></SUP>";
		private static string m_ProductNameTitle = "PolicyTech";//Displays in the title bar.
		private static string m_CompanyName = "NAVEX Global";
		private static string m_HelpURL = "http://helpfiles.policytech.com/?Version=" + HttpUtility.UrlEncode(ProdVersion);
		private static string m_ProductURL = "http://www.navexglobal.com/products/policy-management/?s=product&version=" + HttpUtility.UrlEncode(ProdVersion) + "&utm_medium=Link&utm_source=PPM%20Software";
		private static string m_PurchaseURL = "http://www.policytech.com/products/ppm/purchase/?Version=" + HttpUtility.UrlEncode(ProdVersion);
		private static string m_PrivacyStatmentURL = "http://www.navexglobal.com/privacy-statement";
		private static string m_TermsOfUseUrl = "http://www.navexglobal.com/terms-of-use";
		private static string m_WordModuleFileNameExt_IE32Bit = "_Win32.cab";
		private static string m_WordModuleFileNameExt_IE64Bit = "_x64.cab";
		private static string m_WordModuleFileNameExt_Firefox = "_Installer_Win32.msi";
		private static string m_WordModuleFileNameExt_Chrome = "_Installer_Win32.msi";
		private static string m_WordModuleFileNameExt_Mac = "_Mac.pkg";
		private static string m_WordModuleFileNameBase = "OfficeModule";
		private static string m_WordModuleClassID = "BAC16126-1812-41a1-AD18-66B3FC8DFEDA";
		private static string m_WordModuleEnforcedVersion = "3.5.915.0";
		private static string m_WordModuleCurrVersion = "3.5.1519.0"; // 3.5.1509.0 is the minimum requirement for supporting Chrome 34+; 3.5.1514 is the minimum requirement for supporting Firefox 43+
		private static string m_WordModuleVersionFirefox = "3.5.1188.0";
		private static string m_MinimumLiquidModuleVersion = "3.5.1188.0"; // The minimum requirement for the Liquid Module
		private static string m_MinimumNativeAppVersion = "1.1.78"; // The minimum requirement for the Native App
		private static string m_MinimumWordModuleVersion_Compare = "3.5.1220.0"; // The minimum requirement for features related to Compare Document features
		private static string m_MinimumWordModuleVersion_InsertLogo = "3.5.1376.0"; // The minimum requirement for InsertLogo and updating logos
		private static string m_MinimumWordModuleVersion_SetWatermark = "3.5.1412.0"; // The minimum requirement for javascript SetWatermark function availability
		private static string m_MinimumWordModuleVersion_PrintAllLaunchOutside = "3.5.1236.0"; // The minimum requirement for "Print All" to work with "Launch Document Outside of Browser"
		private static string m_LDAPRCSVersion = "1.2.0";
		private static char[] m_InvalidChars = new char[] { '<', '|', '^' };
		private static string m_URLDocView = "/docview/";
		private static string m_LinkIdentifier = "Link_";
		private static string m_WordModuleNewLineCharacter = "<br>";
		private static string m_DocumentPopupWindowParams = "height=635,width=930,location=yes,menubar=no,resizable=yes,status=yes,scrollbars=yes,titlebar=no,toolbar=no";
		private static string m_ReportPopupWindowParams = "height=635,width=1053,location=yes,menubar=no,resizable=yes,status=no,scrollbars=yes,titlebar=no,toolbar=no";
		private static string m_HelpPopupWindowParams = "height=635,width=910,location=yes,menubar=no,resizable=yes,status=yes,scrollbars=yes,titlebar=no,toolbar=no"; // If you change these parameters, change them in Utils.ts too
		private static string m_ExternalLinksPopupWindowParams = "height=635,width=910,location=yes,menubar=yes,resizable=yes,status=yes,scrollbars=yes,titlebar=Yes,toolbar=yes";
		private static string m_Stars = "**********";

		//WARNING: DO NOT CHANGE THESE CULTURE CODES. CLIENTS COULD BE USING THEM, AND THE CRM HAS TO HAVE AN EXACT DUPLICATE
		private static Dictionary<string, string> m_LanguageCultureCodes = new Dictionary<string, string> {
			{"defaultenglish",""},
			{"af-ZA","Afrikaans (South Africa)"},
			{"ar-AE","Arabic (United Arab Emirates)"},
			{"ar-BH","Arabic (Bahrain)"},
			{"ar-DZ","Arabic (Algeria)"},
			{"ar-EG","Arabic (Egypt)"},
			{"ar-IQ","Arabic (Iraq)"},
			{"ar-JO","Arabic (Jordan)"},
			{"ar-KW","Arabic (Kuwait)"},
			{"ar-LB","Arabic (Lebanon)"},
			{"ar-LY","Arabic (Libya)"},
			{"ar-MA","Arabic (Morocco)"},
			{"ar-OM","Arabic (Oman)"},
			{"ar-QA","Arabic (Qatar)"},
			{"ar-SA","Arabic (Saudi Arabia)"},
			{"ar-SY","Arabic (Syria)"},
			{"ar-TN","Arabic (Tunisia)"},
			{"ar-YE","Arabic (Yemen)"},
			{"be-BY","Belarusian (Belarus)"},
			{"bg-BG","Bulgarian (Bulgaria)"},
			{"ca-ES","Catalan (Catalan)"},
			{"cs-CZ","Czech (Czech Republic)"},
			{"da-DK","Danish (Denmark)"},
			{"de-AT","German (Austria)"},
			{"de-CH","German (Switzerland)"},
			{"de-DE","German (Germany)"},
			{"de-LI","German (Liechtenstein)"},
			{"de-LU","German (Luxembourg)"},
			{"dv-MV","Dhivehi (Maldives)"},
			{"el-GR","Greek (Greece)"},
			{"en-029","English (Caribbean)"},
			{"en-AU","English (Australia)"},
			{"en-BZ","English (Belize)"},
			{"en-CA","English (Canada)"},
			{"en-GB","English (United Kingdom)"},
			{"en-IE","English (Ireland)"},
			{"en-JM","English (Jamaica)"},
			{"en-NZ","English (New Zealand)"},
			{"en-PH","English (Philippines)"},
			{"en-TT","English (Trinidad and Tobago)"},
			{"en-US","English (United States)"},
			{"en-ZA","English (South Africa)"},
			{"en-ZW","English (Zimbabwe)"},
			{"es-AR","Spanish (Argentina)"},
			{"es-BO","Spanish (Bolivia)"},
			{"es-CL","Spanish (Chile)"},
			{"es-CO","Spanish (Colombia)"},
			{"es-CR","Spanish (Costa Rica)"},
			{"es-DO","Spanish (Dominican Republic)"},
			{"es-EC","Spanish (Ecuador)"},
			{"es-ES","Spanish (Spain)"},
			{"es-GT","Spanish (Gatemala)"},
			{"es-HN","Spanish (Honduras)"},
			{"es-MX","Spanish (Mexico)"},
			{"es-NI","Spanish (Nicaragua)"},
			{"es-PA","Spanish (Panama)"},
			{"es-PE","Spanish (Peru)"},
			{"es-PR","Spanish (Puerto Rico)"},
			{"es-PY","Spanish (Colombia)"},
			{"es-SV","Spanish (Paraguay)"},
			{"es-UY","Spanish (Uruguay)"},
			{"es-VE","Spanish (Venezuela)"},
			{"et-EE","Spanish (Colombia)"},
			{"eu-ES","Estonian (Estonia)"},
			{"fa-IR","Farsi (Iran)"},
			{"fi-FI","Finnish (Finland)"},
			{"fo-FO","Faroese (Faroe Islands)"},
			{"fr-BE","French (Belgium)"},
			{"fr-CA","French (Canada)"},
			{"fr-CH","French (Switzerland)"},
			{"fr-FR","French (France)"},
			{"fr-LU","French (Luxembourg)"},
			{"fr-MC","French (Monaco)"},
			{"gl-ES","Galician (Galician)"},
			{"gu-IN","Gujarati (India)"},
			{"he-IL","Hebrew (Israel)"},
			{"hi-IN","Hindi (India)"},
			{"hr-HR","Croatian (Croatia)"},
			{"hu-HU","Hungarian (Hungary)"},
			{"hy-AM","Armenian (Armenia)"},
			{"id-ID","Indonesian (Indonesia)"},
			{"is-IS","Icelandic (Iceland)"},
			{"it-CH","Italian (Switzerland)"},
			{"it-IT","Italian (Italy)"},
			{"ja-JP","Japanese (Japan)"},
			{"ka-GE","Georgian (Georgia)"},
			{"kk-KZ","Kazakh (Kazakhstan)"},
			{"kn-IN","Kannada (India)"},
			{"kok-IN","Konkani (India)"},
			{"ko-KR","Korean (Korea)"},
			{"ky-KG","Kyrgyz (Kyrgyzstan)"},
			{"lt-LT","Lithuanian (Lithuania)"},
			{"lv-LV","Latvian (Latvia)"},
			{"mk-MK","Macedonian (FYROM)"},
			{"mn-MN","Mongolian (Mongolia)"},
			{"mr-IN","Marathi (India)"},
			{"ms-BN","Malay (Brunei)"},
			{"ms-MY","Malay (Malaysia)"},
			{"nb-NO","Norwegian - Bokmål (Norway)"},
			{"nl-BE","Dutch (Belgium)"},
			{"nl-NL","Dutch (The Netherlands)"},
			{"nn-NO","Norwegian - Nynorsk (Norway)"},
			{"pa-IN","Punjabi (India)"},
			{"pl-PL","Polish (Poland)"},
			{"pt-BR","Portuguese (Brazil)"},
			{"pt-PT","Portuguese (Portugal)"},
			{"ro-RO","Romanian (Romania)"},
			{"ru-RU","Russian (Russia)"},
			{"sa-IN","Sanskrit (India)"},
			{"sk-SK","Slovak (Slovakia)"},
			{"sl-SI","Slovenian (Slovenia)"},
			{"sq-AL","Albanian (Albania)"},
			{"sv-FI","Swedish (Finland)"},
			{"sv-SE","Swedish (Sweden)"},
			{"sw-KE","Swahili (Kenya)"},
			{"syr-SY","Syriac (Syria)"},
			{"ta-IN","Tamil (India)"},
			{"te-IN","Telugu (India)"},
			{"th-TH","Thai (Thailand)"},
			{"tr-TR","Turkish (Turkey)"},
			{"tt-RU","Tatar (Russia)"},
			{"uk-UA","Ukrainian (Ukraine)"},
			{"ur-PK","Urdu (Pakistan)"},
			{"vi-VN","Vietnamese (Vietnam)"},
			{"zh-CN","Chinese (China)"},
			{"zh-Hans","Chinese (Simplified)"},
			{"zh-Hant","Chinese (Traditional)"},
			{"zh-CHS","Chinese (Simplified)"},
			{"zh-CHT","Chinese (Traditional)"},
			{"zh-HK","Chinese (Hong Kong SAR)"},
			{"zh-MO","Chinese (Macau SAR)"},
			{"zh-SG","Chinese (Singapore)"},
			{"zh-TW","Chinese (Taiwan)"},
			{"zu-ZA","isiZulu (South Africa)"}};

		private static string m_CommentsFlagProxy = "<area:proxycomments:v1:1>";
		private static string m_CommentsFlagRequestor = "<area:requestorcomments:v1:1>";

		#region MIME Types
		public static readonly Hashtable MimeTypes = new Hashtable {
			{ "3dm", "x-world/x-3dmf" },
			{ "3dmf", "x-world/x-3dmf" },
			{ "a", "application/octet-stream" },
			{ "aab", "application/x-authorware-bin" },
			{ "aam", "application/x-authorware-map" },
			{ "aas", "application/x-authorware-seg" },
			{ "abc", "text/vnd.abc" },
			{ "acgi", "text/html" },
			{ "afl", "video/animaflex" },
			{ "ai", "application/postscript" },
			{ "aif", "audio/aiff" },
			{ "aifc", "audio/aiff" },
			{ "aiff", "audio/aiff" },
			{ "aim", "application/x-aim" },
			{ "aip", "text/x-audiosoft-intra" },
			{ "ani", "application/x-navi-animation" },
			{ "aos", "application/x-nokia-9000-communicator-add-on-software" },
			{ "aps", "application/mime" },
			{ "arc", "application/octet-stream" },
			{ "arj", "application/arj" },
			{ "art", "image/x-jg" },
			{ "asf", "video/x-ms-asf" },
			{ "asm", "text/x-asm" },
			{ "asp", "text/asp" },
			{ "asx", "application/x-mplayer2" },
			{ "au", "audio/basic" },
			{ "avi", "video/msvideo" },
			{ "avs", "video/avs-video" },
			{ "bcpio", "application/x-bcpio" },
			{ "bin", "application/octet-stream" },
			{ "bm", "image/bmp" },
			{ "bmp", "image/bmp" },
			{ "boo", "application/book" },
			{ "book", "application/book" },
			{ "boz", "application/x-bzip2" },
			{ "bsh", "application/x-bsh" },
			{ "bz", "application/x-bzip" },
			{ "bz2", "application/x-bzip2" },
			{ "c", "text/plain" },
			{ "c++", "text/plain" },
			{ "cat", "application/vnd.ms-pki.seccat" },
			{ "cc", "text/plain" },
			{ "ccad", "application/clariscad" },
			{ "cco", "application/x-cocoa" },
			{ "cdf", "application/cdf" },
			{ "cer", "application/pkix-cert" },
			{ "cha", "application/x-chat" },
			{ "chat", "application/x-chat" },
			{ "class", "application/java" },
			{ "com", "application/octet-stream" },
			{ "conf", "text/plain" },
			{ "cpio", "application/x-cpio" },
			{ "cpp", "text/x-c" },
			{ "cpt", "application/mac-compactpro" },
			{ "crl", "application/pkcs-crl" },
			{ "crt", "application/pkix-cert" },
			{ "csh", "application/x-csh" },
			{ "css", "text/css" },
			{ "cxx", "text/plain" },
			{ "dcr", "application/x-director" },
			{ "deepv", "application/x-deepv" },
			{ "def", "text/plain" },
			{ "der", "application/x-x509-ca-cert" },
			{ "dif", "video/x-dv" },
			{ "dir", "application/x-director" },
			{ "dl", "video/dl" },
			{ "doc", "application/msword" },
			{ "dot", "application/msword" },
			{ "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
			{ "dp", "application/commonground" },
			{ "drw", "application/drafting" },
			{ "dump", "application/octet-stream" },
			{ "dv", "video/x-dv" },
			{ "dvi", "application/x-dvi" },
			{ "dwf", "model/vnd.dwf" },
			{ "dwg", "application/acad" },
			{ "dxf", "image/x-dwg" },
			{ "dxr", "application/x-director" },
			{ "el", "text/x-script.elisp" },
			{ "elc", "application/x-elc" },
			{ "eml", "message/rfc822" },
			{ "env", "application/x-envoy" },
			{ "eps", "application/postscript" },
			{ "es", "application/x-esrehber" },
			{ "esp", "text/html" },
			{ "etx", "text/x-setext" },
			{ "evy", "application/envoy" },
			{ "exe", "application/octet-stream" },
			{ "f", "text/plain" },
			{ "f77", "text/x-fortran" },
			{ "f90", "text/plain" },
			{ "fdf", "application/vnd.fdf" },
			{ "fif", "image/fif" },
			{ "fli", "video/fli" },
			{ "flo", "image/florian" },
			{ "flx", "text/vnd.fmi.flexstor" },
			{ "fmf", "video/x-atomic3d-feature" },
			{ "for", "text/plain" },
			{ "fpx", "image/vnd.fpx" },
			{ "frl", "application/freeloader" },
			{ "funk", "audio/make" },
			{ "g", "text/plain" },
			{ "g3", "image/g3fax" },
			{ "gif", "image/gif" },
			{ "gl", "video/x-gl" },
			{ "gsd", "audio/x-gsm" },
			{ "gsm", "audio/x-gsm" },
			{ "gsp", "application/x-gsp" },
			{ "gss", "application/x-gss" },
			{ "gtar", "application/x-gtar" },
			{ "gz", "application/x-gzip" },
			{ "gzip", "application/x-gzip" },
			{ "h", "text/plain" },
			{ "hdf", "application/x-hdf" },
			{ "help", "application/x-helpfile" },
			{ "hgl", "application/vnd.hp-HPGL" },
			{ "hh", "text/plain" },
			{ "hlb", "text/x-script" },
			{ "hlp", "application/hlp" },
			{ "hpg", "application/vnd.hp-HPGL" },
			{ "hpgl", "application/vnd.hp-HPGL" },
			{ "hqx", "application/binhex" },
			{ "hta", "application/hta" },
			{ "htc", "text/x-component" },
			{ "htm", "text/html" },
			{ "html", "text/html" },
			{ "htmls", "text/html" },
			{ "htt", "text/webviewhtml" },
			{ "htx", "text/html" },
			{ "ice", "x-conference/x-cooltalk" },
			{ "ico", "image/x-icon" },
			{ "idc", "text/plain" },
			{ "ief", "image/ief" },
			{ "iefs", "image/ief" },
			{ "iges", "application/iges" },
			{ "igs", "application/iges" },
			{ "ima", "application/x-ima" },
			{ "imap", "application/x-httpd-imap" },
			{ "inf", "application/inf" },
			{ "ins", "application/x-internett-signup" },
			{ "ip", "application/x-ip2" },
			{ "isu", "video/x-isvideo" },
			{ "it", "audio/it" },
			{ "iv", "application/x-inventor" },
			{ "ivr", "i-world/i-vrml" },
			{ "ivy", "application/x-livescreen" },
			{ "jam", "audio/x-jam" },
			{ "jav", "text/plain" },
			{ "java", "text/plain" },
			{ "jcm", "application/x-java-commerce" },
			{ "jfif", "image/jpeg" },
			{ "jfif-tbnl", "image/jpeg" },
			{ "jpe", "image/jpeg" },
			{ "jpeg", "image/jpeg" },
			{ "jpg", "image/jpeg" },
			{ "jps", "image/x-jps" },
			{ "js", "application/x-javascript" },
			{ "jsp", "text/html" },
			{ "jut", "image/jutvision" },
			{ "kar", "audio/midi" },
			{ "ksh", "application/x-ksh" },
			{ "la", "audio/nspaudio" },
			{ "lam", "audio/x-liveaudio" },
			{ "latex", "application/x-latex" },
			{ "lha", "application/octet-stream" },
			{ "lhx", "application/octet-stream" },
			{ "list", "text/plain" },
			{ "lma", "audio/nspaudio" },
			{ "log", "text/plain" },
			{ "lsp", "application/x-lisp" },
			{ "lst", "text/plain" },
			{ "lsx", "text/x-la-asf" },
			{ "ltx", "application/x-latex" },
			{ "lzh", "application/octet-stream" },
			{ "lzx", "application/octet-stream" },
			{ "m", "text/x-m" },
			{ "m1v", "video/mpeg" },
			{ "m2a", "audio/mpeg" },
			{ "m2v", "video/mpeg" },
			{ "m3u", "audio/x-mpequrl" },
			{ "man", "application/x-troff-man" },
			{ "map", "application/x-navimap" },
			{ "mar", "text/plain" },
			{ "mbd", "application/mbedlet" },
			{ "mc$", "application/x-magic-cap-package-1.0" },
			{ "mcd", "application/mcad" },
			{ "mcf", "text/mcf" },
			{ "mcp", "application/netmc" },
			{ "me", "application/x-troff-me" },
			{ "mht", "message/rfc822" },
			{ "mhtml", "message/rfc822" },
			{ "mid", "audio/midi" },
			{ "midi", "audio/midi" },
			{ "mif", "application/x-frame" },
			{ "mime", "message/rfc822" },
			{ "mjf", "audio/x-vnd.AudioExplosion.MjuiceMediaFile" },
			{ "mjpg", "video/x-motion-jpeg" },
			{ "mm", "application/base64" },
			{ "mme", "application/base64" },
			{ "mod", "audio/mod" },
			{ "moov", "video/quicktime" },
			{ "mov", "video/quicktime" },
			{ "movie", "video/x-sgi-movie" },
			{ "mp2", "audio/mpeg" },
			{ "mp3", "audio/mpeg3" },
			{ "mpa", "audio/mpeg" },
			{ "mpc", "application/x-project" },
			{ "mpe", "video/mpeg" },
			{ "mpeg", "video/mpeg" },
			{ "mpg", "audio/mpeg" },
			{ "mpga", "audio/mpeg" },
			{ "mpp", "application/vnd.ms-project" },
			{ "mpt", "application/x-project" },
			{ "mpv", "application/x-project" },
			{ "mpx", "application/x-project" },
			{ "mrc", "application/marc" },
			{ "ms", "application/x-troff-ms" },
			{ "mv", "video/x-sgi-movie" },
			{ "my", "audio/make" },
			{ "mzz", "application/x-vnd.AudioExplosion.mzz" },
			{ "nap", "image/naplps" },
			{ "naplps", "image/naplps" },
			{ "nc", "application/x-netcdf" },
			{ "ncm", "application/vnd.nokia.configuration-message" },
			{ "nif", "image/x-niff" },
			{ "niff", "image/x-niff" },
			{ "nix", "application/x-mix-transfer" },
			{ "nsc", "application/x-conference" },
			{ "nvd", "application/x-navidoc" },
			{ "o", "application/octet-stream" },
			{ "oda", "application/oda" },
			{ "omc", "application/x-omc" },
			{ "omcd", "application/x-omcdatamaker" },
			{ "omcr", "application/x-omcregerator" },
			{ "p", "text/x-pascal" },
			{ "p10", "application/pkcs10" },
			{ "p12", "application/pkcs-12" },
			{ "p7a", "application/x-pkcs7-signature" },
			{ "p7c", "application/pkcs7-mime" },
			{ "p7m", "application/pkcs7-mime" },
			{ "p7r", "application/x-pkcs7-certreqresp" },
			{ "p7s", "application/pkcs7-signature" },
			{ "part", "application/pro_eng" },
			{ "pas", "text/pascal" },
			{ "pbm", "image/x-portable-bitmap" },
			{ "pcl", "application/x-pcl" },
			{ "pct", "image/x-pict" },
			{ "pcx", "image/x-pcx" },
			{ "pdb", "chemical/x-pdb" },
			{ "pdf", "application/pdf" },
			{ "pfunk", "audio/make" },
			{ "pgm", "image/x-portable-greymap" },
			{ "php", "text/html" },
			{ "php3", "text/html" },
			{ "php4", "text/html" },
			{ "phps", "text/html" },
			{ "phtml", "text/html" },
			{ "pic", "image/pict" },
			{ "pict", "image/pict" },
			{ "pkg", "application/x-newton-compatible-pkg" },
			{ "pko", "application/vnd.ms-pki.pko" },
			{ "pl", "text/plain" },
			{ "plx", "application/x-PiXCLscript" },
			{ "pm", "image/x-xpixmap" },
			{ "pm4 ", "application/x-pagemaker" },
			{ "pm5", "application/x-pagemaker" },
			{ "png", "image/png" },
			{ "pnm", "application/x-portable-anymap" },
			{ "pot", "application/mspowerpoint" },
			{ "pov", "model/x-pov" },
			{ "ppa", "application/vnd.ms-powerpoint" },
			{ "ppm", "image/x-portable-pixmap" },
			{ "pps", "application/mspowerpoint" },
			{ "ppt", "application/mspowerpoint" },
			{ "pptx", "application/mspowerpoint" },
			{ "ppz", "application/mspowerpoint" },
			{ "pre", "application/x-freelance" },
			{ "prt", "application/pro_eng" },
			{ "ps", "application/postscript" },
			{ "psd", "application/octet-stream" },
			{ "pvu", "paleovu/x-pv" },
			{ "pwz", "application/vnd.ms-powerpoint" },
			{ "py", "text/x-script.phyton" },
			{ "pyc", "applicaiton/x-bytecode.python" },
			{ "qcp", "audio/vnd.qcelp" },
			{ "qd3", "x-world/x-3dmf" },
			{ "qd3d", "x-world/x-3dmf" },
			{ "qif", "image/x-quicktime" },
			{ "qt", "video/quicktime" },
			{ "qtc", "video/x-qtc" },
			{ "qti", "image/x-quicktime" },
			{ "qtif", "image/x-quicktime" },
			{ "ra", "audio/x-realaudio" },
			{ "ram", "audio/x-pn-realaudio" },
			{ "ras", "image/cmu-raster" },
			{ "rast", "image/cmu-raster" },
			{ "rex", "text/x-script.rexx" },
			{ "rexx", "text/x-script.rexx" },
			{ "rf", "image/vnd.rn-realflash" },
			{ "rgb", "image/x-rgb" },
			{ "rm", "audio/x-pn-realaudio" },
			{ "rmi", "audio/mid" },
			{ "rmm", "audio/x-pn-realaudio" },
			{ "rmp", "audio/x-pn-realaudio" },
			{ "rng", "application/vnd.nokia.ringing-tone" },
			{ "rnx", "application/vnd.rn-realplayer" },
			{ "roff", "application/x-troff" },
			{ "rp", "image/vnd.rn-realpix" },
			{ "rpm", "audio/x-pn-realaudio-plugin" },
			{ "rt", "text/richtext" },
			{ "rtf", "application/rtf" },
			{ "rtx", "application/rtf" },
			{ "rv", "video/vnd.rn-realvideo" },
			{ "s", "text/x-asm" },
			{ "s3m", "audio/s3m" },
			{ "saveme", "application/octet-stream" },
			{ "sbk", "application/x-tbook" },
			{ "scm", "application/x-lotusscreencam" },
			{ "sdml", "text/plain" },
			{ "sdp", "application/sdp" },
			{ "sdr", "application/sounder" },
			{ "sea", "application/x-sea" },
			{ "set", "application/set" },
			{ "sgm", "text/sgml" },
			{ "sgml", "text/sgml" },
			{ "sh", "application/x-sh" },
			{ "shar", "application/x-shar" },
			{ "shtml", "text/html" },
			{ "sid", "audio/x-psid" },
			{ "sit", "application/x-stuffit" },
			{ "skd", "application/x-koan" },
			{ "skm", "application/x-koan" },
			{ "skp", "application/x-koan" },
			{ "skt", "application/x-koan" },
			{ "sl", "application/x-seelogo" },
			{ "smi", "application/smil" },
			{ "smil", "application/smil" },
			{ "snd", "audio/basic" },
			{ "sol", "application/solids" },
			{ "spc", "text/x-speech" },
			{ "spl", "application/futuresplash" },
			{ "spr", "application/x-sprite" },
			{ "sprite", "application/x-sprite" },
			{ "src", "application/x-wais-source" },
			{ "ssi", "text/x-server-parsed-html" },
			{ "ssm", "application/streamingmedia" },
			{ "sst", "application/vnd.ms-pki.certstore" },
			{ "step", "application/step" },
			{ "stl", "application/sla" },
			{ "stp", "application/step" },
			{ "sv4cpio", "application/x-sv4cpio" },
			{ "sv4crc", "application/x-sv4crc" },
			{ "svf", "image/vnd.dwg" },
			{ "svg", "image/svg+xml" },
			{ "svr", "application/x-world" },
			{ "swf", "application/x-shockwave-flash" },
			{ "t", "application/x-troff" },
			{ "talk", "text/x-speech" },
			{ "tar", "application/x-tar" },
			{ "tbk", "application/toolbook" },
			{ "tcl", "application/x-tcl" },
			{ "tcsh", "text/x-script.tcsh" },
			{ "tex", "application/x-tex" },
			{ "texi", "application/x-texinfo" },
			{ "texinfo", "application/x-texinfo" },
			{ "text", "text/plain" },
			{ "tgz", "application/x-compressed" },
			{ "tif", "image/tiff" },
			{ "tiff", "image/tiff" },
			{ "tr", "application/x-troff" },
			{ "tsi", "audio/tsp-audio" },
			{ "tsp", "audio/tsplayer" },
			{ "tsv", "text/tab-separated-values" },
			{ "turbot", "image/florian" },
			{ "txt", "text/plain" },
			{ "uil", "text/x-uil" },
			{ "uni", "text/uri-list" },
			{ "unis", "text/uri-list" },
			{ "unv", "application/i-deas" },
			{ "uri", "text/uri-list" },
			{ "uris", "text/uri-list" },
			{ "ustar", "application/x-ustar" },
			{ "uu", "application/octet-stream" },
			{ "uue", "text/x-uuencode" },
			{ "vcd", "application/x-cdlink" },
			{ "vcs", "text/x-vCalendar" },
			{ "vda", "application/vda" },
			{ "vdo", "video/vdo" },
			{ "vew ", "application/groupwise" },
			{ "viv", "video/vivo" },
			{ "vivo", "video/vivo" },
			{ "vmd", "application/vocaltec-media-desc" },
			{ "vmf", "application/vocaltec-media-file" },
			{ "voc", "audio/voc" },
			{ "vos", "video/vosaic" },
			{ "vox", "audio/voxware" },
			{ "vqe", "audio/x-twinvq-plugin" },
			{ "vqf", "audio/x-twinvq" },
			{ "vql", "audio/x-twinvq-plugin" },
			{ "vrml", "application/x-vrml" },
			{ "vrt", "x-world/x-vrt" },
			{ "vsd", "application/x-visio" },
			{ "vss", "application/x-visio" },
			{ "vst", "application/x-visio" },
			{ "vdx", "application/x-visio" },
			{ "vsx", "application/x-visio" },
			{ "vtx", "application/x-visio" },
			{ "vsw", "application/x-visio" },
			{ "w60", "application/wordperfect6.0" },
			{ "w61", "application/wordperfect6.1" },
			{ "w6w", "application/msword" },
			{ "wav", "audio/wav" },
			{ "wb1", "application/x-qpro" },
			{ "wbmp", "image/vnd.wap.wbmp" },
			{ "web", "application/vnd.xara" },
			{ "wiz", "application/msword" },
			{ "wk1", "application/x-123" },
			{ "wmf", "windows/metafile" },
			{ "wml", "text/vnd.wap.wml" },
			{ "wmlc", "application/vnd.wap.wmlc" },
			{ "wmls", "text/vnd.wap.wmlscript" },
			{ "wmlsc", "application/vnd.wap.wmlscriptc" },
			{ "word", "application/msword" },
			{ "wp", "application/wordperfect" },
			{ "wp5", "application/wordperfect" },
			{ "wp6", "application/wordperfect" },
			{ "wpd", "application/wordperfect" },
			{ "wq1", "application/x-lotus" },
			{ "wri", "application/mswrite" },
			{ "wrl", "model/vrml" },
			{ "wrz", "model/vrml" },
			{ "wsc", "text/scriplet" },
			{ "wsrc", "application/x-wais-source" },
			{ "wtk", "application/x-wintalk" },
			{ "xbm", "image/xbm" },
			{ "xdr", "video/x-amt-demorun" },
			{ "xgz", "xgl/drawing" },
			{ "xif", "image/vnd.xiff" },
			{ "xl", "application/excel" },
			{ "xla", "application/excel" },
			{ "xlb", "application/excel" },
			{ "xlc", "application/excel" },
			{ "xld", "application/excel" },
			{ "xlk", "application/excel" },
			{ "xll", "application/excel" },
			{ "xlm", "application/excel" },
			{ "xls", "application/excel" },
			{ "xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" },
			{ "xlt", "application/excel" },
			{ "xlv", "application/excel" },
			{ "xlw", "application/excel" },
			{ "xm", "audio/xm" },
			{ "xml", "text/xml" },
			{ "xmz", "xgl/movie" },
			{ "xpix", "application/x-vnd.ls-xpix" },
			{ "xpm", "image/xpm" },
			{ "x-png", "image/png" },
			{ "xsr", "video/x-amt-showrun" },
			{ "xwd", "image/x-xwd" },
			{ "xyz", "chemical/x-pdb" },
			{ "z", "application/x-compress" },
			{ "zip", "application/zip" },
			{ "zoo", "application/octet-stream" },
			{ "zsh", "text/x-script.zsh" } };

		#endregion

		#region Advanced Search Stored Procedure
		// Line Brakes do matter in the query so do not colapse to single line
		private static string m_ReturnPageParameters = "@Select varchar(8000), @OrderBy varchar(1000), @StartRow int, @EndRow int";
		private static string m_ReturnPageSql =
			@"
			declare @ColList varchar(2000);

			declare @Where varchar(2000);

			declare @i int; 

			declare @i2 int;

			declare @tmp varchar(1000);

			declare @dec varchar(1000);

			declare @f varchar(100);

			declare @d varchar(100);

			declare @Symbol char(2);

			declare @SQL varchar(5000);
			
			declare @StartRowChar varchar(10);
			
			declare @EndRowChar varchar(10);

			declare @SubSQL varchar(5000);

			declare @SubWhere varchar(5000);

			declare @Sort varchar(1000);


			set @Sort = @OrderBy + ', '

			set @dec = ''

			set @Where  = ''

			set @SQL = ''

			set @StartRowChar = convert(varchar(10), @StartRow);

			set @EndRowChar = convert(varchar(10), 1 + @EndRow - @StartRow);

			set @i = charindex(',' , @Sort)

			while @i != 0

			 begin

			  set @tmp = left(@Sort,@i-1)

			  set @i2 = charindex(' ', @tmp)

			  set @f = ltrim(rtrim(left(@tmp,@i2-1)))

			  set @d = ltrim(rtrim(substring(@tmp,@i2+1,100)))

			  set @Sort = rtrim(ltrim(substring(@Sort,@i+1,100)))

			  set @i = charindex(',', @Sort)

			  set @Symbol = case when @d = 'ASC' then '>' else '<' end +

								 case when @i=0 then '=' else '' end

			 

			  set @dec = @dec + 'declare @' + @f + ' sql_variant; '

			  set @ColList = isnull(replace(replace(@ColList,'>','='),'<','=') + ' and ','') +

								  @f + @Symbol + ' @' + @f

			  set @Where = @Where + ' OR (' + @ColList + ') '

			  set @SQL = @SQL + ', @' + @f + '= ' + @f

			 end
			 
			set @SubSQL = substring(@SQL,3,7000)

			set @SubWhere = substring(@Where,4,7000)
			
			exec(@dec + ' ' +  'SET ROWCOUNT ' + @StartRowChar + '; ' +

				'SELECT ' + @SubSQL + ' from (' + @Select + ') a ORDER BY ' +

						  @OrderBy + '; ' + 'SET ROWCOUNT ' +

						  @EndRowChar + '; ' +

						  'select * from (' + @Select + ') a WHERE ' +

						  @SubWhere + ' ORDER BY ' + @OrderBy + '; SET ROWCOUNT 0;')

			";
		#endregion

		public static string AcessLevelOne {
			get { return "1"; }
		}

		#region Getters and Setters
		public static string CategoryDateSeparator {
			get { return "[CatDateSeparator]"; }
		}
		public static char groupSeparator {
			get { return m_groupSeparator; }
		}

		public static char unitSeparator {
			get { return m_unitSeparator; }
		}

		public static char recordSeparator {
			get { return m_recordSeparator; }
		}

		public static string ComplianceApproverSymbol {
			get { return ((char) 176).ToString(); }
		}

		public static string DocumentPopupWindowParams {
			get { return m_DocumentPopupWindowParams; }
		}

		public static string ExternalLinksPopupWindowParams {
			get { return m_ExternalLinksPopupWindowParams; }
		}

		public static string ReportPopupWindowParams {
			get { return m_ReportPopupWindowParams; }
		}

		public static string HelpPopupWindowParams {
			get { return m_HelpPopupWindowParams; }
		}

		public static char[] InvalidCharsAsCharArray {
			get { return m_InvalidChars; }
		}

		public static string URLDocView {
			get { return m_URLDocView; }
		}

		public static string LinkIdentifier {
			get { return m_LinkIdentifier; }
		}

		public static string WordModuleNewLineCharacter {
			get { return m_WordModuleNewLineCharacter; }
		}

		public static string CommentsFlagProxy {
			get { return m_CommentsFlagProxy; }
		}

		public static string CommentsFlagRequestor {
			get { return m_CommentsFlagRequestor; }
		}

		public static string InvalidCharsAsStringWithoutCommas {
			get {
				string invalidCharsString = "";

				foreach (char character in m_InvalidChars) {
					invalidCharsString += character;
				}

				return invalidCharsString;
			}
		}

		/// <summary>
		/// Generates a string containing the invalid characters separated with spaces. For use in showing the user which characters are not allowed.
		/// </summary>
		public static string InvalidCharsForDisplayToUser {
			get {
				string charsString = "";

				foreach (char character in m_InvalidChars) {
					charsString += character + " ";
				}

				// Remove the last space
				int invalidCharsStringLength = charsString.Length;
				if (invalidCharsStringLength > 0) {
					charsString = charsString.Remove(invalidCharsStringLength - 1, 1);
				}

				return charsString;
			}
		}

		public static string InvlaidCharsAsStringWithoutCommas {
			get {
				string invalidCharsString = "";

				foreach (char character in m_InvalidChars) {
					invalidCharsString += character;
				}

				return invalidCharsString;
			}
		}


		/// <summary>
		/// Generates a regular expression with the reserved chars. For use in regular expression validators.
		/// </summary>
		public static string InvalidCharsForUseInRegularExpressionValidator {
			get {
				// Generates a regular expression string that looks like this: [^<|\\^]+

				string invalidCharsString = "[^";

				foreach (char character in m_InvalidChars) {
					if (character == '^') { // ^ is a special character used by regular expressions so it needs to be escaped
						invalidCharsString += "\\";
					}
					invalidCharsString += character;
				}

				invalidCharsString += "]+";

				return invalidCharsString;
			}
		}

		public static string InvalidCharsRegularExpression {
			get { return "[<|\\^]+"; }
		}

		// unsafe chars = < > | ' ; " ^
		public static Regex UnsafeChars = new Regex(Constants.UnsafeCharsRegularExpression, RegexOptions.Compiled);
		public static string UnsafeCharsRegularExpression {
			get { return "[<>';^\"]+"; }
		}

		public static string EmailRegularExpression {
			get { return @"^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?"; }
		}

		public static string URLRegularExpression {
			get { return @"^(http|ftp|https):\/\/[\w\-_]+(\.?[\w\-_]+)+([\w\-\.?,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?"; }
		}

		public static string IPAddressRegularExpression {
			get { return @"^((\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*-\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:([0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?))|((\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b\-\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b)))(,((\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*-\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:([0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?))|((\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b\-\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b)+)))*$"; }
		}

		public static string PhoneNumberRegularExpression { //There are many different formats and different ways of writing numbers, that we'll just restrict them to certain characters, but not formats.
			get { return @"^([0-9]|-|\s|\(|\)|\+|\#){1,25}$"; }
		}

		public static string ProductID {
			get { return m_ProductID; }
		}

		public static string ProductMajorVersion {
			get { return m_ProductMajorVersion; }
		}

		public static string ProductMinorVersion {
			get { return m_ProductMinorVersion; }
		}

		public static string ProductVersionRevision {
			get { return m_ProductVersionRevision; }
		}

		public static string ProductVersionDate {
			get { return m_ProductVersionDate; }
		}

		public static string ProdVersion {
			get { return m_ProductMajorVersion + "_" + m_ProductMinorVersion + "_" + m_ProductVersionRevision; }
		}

		public static string ProductVersion {
			get { return m_ProductMajorVersion + "." + m_ProductMinorVersion.Substring(0, 1) + "." + Convert.ToInt32(m_ProductMinorVersion.Substring(m_ProductMinorVersion.Length - 2, 2)).ToString() + "." + m_ProductVersionRevision; }
		}

		public static string CurrentDBSchemaVersion {
			get { return m_CurrentDBSchemaVersion; }
		}

		public static string CurrentDataFolderVersion {
			get { return m_CurrentDataFolderVersion; }
		}

		public static string DefaultWorkflowVersion {
			get { return m_DefaultWorkflowVersion; }
		}

		public static string DraftWorkflowVersion {
			get { return m_DraftWorkflowVersion; }
		}

		public static string SystemWorkflowVersion {
			get { return m_SystemWorkflowVersion; }
		}

		public static string ContractWorkflowVersion {
			get { return m_ContractWorkflowVersion; }
		}

		public static string MetaDataVersionNumber {
			get { return m_MetaDataVersionNumber; }
		}
		public static string EncryptKey {
			get { return m_EncryptKey; }
		}

		public static string EncryptKeyTempFiles {
			get { return m_EncryptKeyTempFiles; }
		}

		public static string ProductName {
			get { return m_ProductName; }
		}

		public static string ProductNameTitle {
			get { return m_ProductNameTitle; }
		}

		public static string ProductNameWithVersion {
			get { return Constants.ProductNameTitle + " " + Constants.ProductVersion; }
		}

		public static string CompanyName {
			get { return m_CompanyName; }
		}

		public static string HelpURL {
			get { return m_HelpURL; }
		}

		public static string ProductURL {
			get { return m_ProductURL; }
		}

		public static string PurchaseURL {
			get { return m_PurchaseURL; }
		}

		public static string PrivacyStatmentUrl {
			get { return m_PrivacyStatmentURL; }
		}

		public static string TermsOfUseUrl {
			get { return m_TermsOfUseUrl; }
		}

		public static string WordModuleFileNameExt_IE32Bit {
			get { return m_WordModuleFileNameExt_IE32Bit; }
		}

		public static string WordModuleFileNameExt_IE64Bit {
			get { return m_WordModuleFileNameExt_IE64Bit; }
		}
		public static string WordModuleFileNameExt_Firefox {
			get { return m_WordModuleFileNameExt_Firefox; }
		}

		public static string WordModuleFileNameExt_Chrome {
			get { return m_WordModuleFileNameExt_Chrome; }
		}

		public static string WordModuleFileNameExt_Mac {
			get { return m_WordModuleFileNameExt_Mac; }
		}

		public static string WordModuleFileNameBase {
			get { return m_WordModuleFileNameBase; }
		}

		public static string WordModuleClassID {
			get { return m_WordModuleClassID; }
		}

		// Represents the version we (the PT devs) are enforcing for this version of PPM
		// Use WordModuleInfo.GetEnforcedWordModuleVersion() to also check the config file and the manually updated Settings
		public static string WordModuleEnforcedVersion {
			get { return m_WordModuleEnforcedVersion; }
		}

		// Represents the version we (the PT devs) are providing in this version of PPM
		// Use WordModuleInfo.GetCurrWordModuleVersion() to also check the config file
		public static string WordModuleCurrVersion {
			get { return m_WordModuleCurrVersion; }
		}

		public static string WordModuleVersionFirefox {
			get { return m_WordModuleVersionFirefox; }
		}

		public static string MinimumLiquidModuleVersion {
			get { return m_MinimumLiquidModuleVersion; }
		}

		public static string MinimumNativeAppVersion {
			get { return m_MinimumNativeAppVersion; }
		}

		public static string MinimumWordModuleVersion_InsertLogo {
			get { return m_MinimumWordModuleVersion_InsertLogo; }
		}

		public static string MinimumWordModuleVersion_SetWatermark {
			get { return m_MinimumWordModuleVersion_SetWatermark; }
		}

		public static string MinimumWordModuleCompareVersion {
			get { return m_MinimumWordModuleVersion_Compare; }
		}

		public static string MinimumWordModuleInsertLogoVersion {
			get { return m_MinimumWordModuleVersion_InsertLogo; }
		}

		public static string MinimumWordModulePrintAllLaunchOutside {
			get { return m_MinimumWordModuleVersion_PrintAllLaunchOutside; }
		}

		public static string LDAPRCSVersion {
			get { return m_LDAPRCSVersion; }
		}

		public static string ReturnPageParameters {
			get { return m_ReturnPageParameters; }
		}

		public static string ReturnPageSql {
			get { return m_ReturnPageSql; }
		}

		public static Dictionary<string, string> LanguageCultureCodes {
			get { return m_LanguageCultureCodes; }
		}

		public static string Stars {
			get { return m_Stars; }
		}
		#endregion

		#region Enumeration Extensions

		private static Dictionary<Enum, string> enumStringValues = new Dictionary<Enum, string>();
		public static object SyncLock = new object();
		// cpotter - 2012-04-18 
		// Only locking the write operation may need to lock read as well but that will have
		// a much larger performance impact to we will wait and see
		public static string StringValueOf(this Enum value) {
			if (!enumStringValues.ContainsKey(value)) {
				lock (SyncLock) {
					if (!enumStringValues.ContainsKey(value)) {
						try {
							FieldInfo fi = value.GetType().GetField(value.ToString());
							DescriptionAttribute[] attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
							if (attributes.Length > 0) {
								enumStringValues.Add(value, attributes[0].Description);
							} else {
								enumStringValues.Add(value, value.ToString());
							}
						} catch (ArgumentException) {
							// Another thread has added the value already.
						}
					}
				}
			}
			return enumStringValues[value];
		}

		public static T EnumValueOf<T>(this string value) {
			string[] names = Enum.GetNames(typeof(T));
			Object parseResult = null;

			foreach (string name in names) {
				parseResult = Enum.Parse(typeof(T), name);

				if (StringValueOf((Enum) parseResult).Equals(value, StringComparison.OrdinalIgnoreCase)) {
					return (T) parseResult;
				}
			}

			if (typeof(T) == typeof(enDocumentFilterMode) || typeof(T) == typeof(enDocumentStatus)) {
				//This is a generic way to compare against the string value if the the attribute does not match the "value" that is passed in
				//else if (((Enum)Enum.Parse(typeof(T), name)).ToString().ToLower().Equals(value.ToLower())) {
				//Going to use specific matches on the enums so that we don't always fall into comparing string values.
				foreach (string name in names) {
					switch (value.ToLower()) {
						case "review":
							return (T) Enum.Parse(typeof(T), value.ToUpper());
						case "approval":
							return (T) Enum.Parse(typeof(T), value.ToUpper());
					}
				}
			}

			throw new ArgumentException("The string (" + value + ") is not a description or value of the specified enum.");
		}

		#endregion

		#region Date Display and Format methods
		public static string getDateFormatString(enImportDateFormats dateFormat) {
			string dfmt = "yyyy.MM.dd";
			switch (dateFormat) {
				case enImportDateFormats.MMDDYYYY_Slash:
					dfmt = "MM/dd/yyyy";
					break;
				case enImportDateFormats.DDMMYYYY_Slash:
					dfmt = "dd/MM/yyyy";
					break;
				case enImportDateFormats.DDMMYYYY_Period:
					dfmt = "dd.MM.yyyy";
					break;
				case enImportDateFormats.DDMMYYYY_Dash:
					dfmt = "dd-MM-yyyy";
					break;
				case enImportDateFormats.YYYYMMDD_Slash:
					dfmt = "yyyy/MM/dd";
					break;
				case enImportDateFormats.YYYYMMDD_Period:
					dfmt = "yyyy.MM.dd";
					break;
				case enImportDateFormats.YYYYMMDD_Dash:
					dfmt = "yyyy-MM-dd";
					break;
				case enImportDateFormats.MMDDYYYY_Dash:
					dfmt = "MM-dd-yyyy";
					break;
			}
			return dfmt;
		}

		public static string getTimeFormatString(enTimeFormats timeFormat) {
			string tfmt = "h:mm tt";
			switch (timeFormat) {
				case enTimeFormats.HHMMampm_Colon:
					tfmt = "h:mm tt";
					break;
				case enTimeFormats.HHMM_Colon:
					tfmt = "HH:mm";
					break;
				case enTimeFormats.HHMMampm_Period:
					tfmt = "h.mm tt";
					break;
				case enTimeFormats.HHMM_Period:
					tfmt = "HH.mm";
					break;
				case enTimeFormats.HHMM_Comma:
					tfmt = "HH,mm";
					break;
			}
			return tfmt;
		}

		public static string ConvertImportDateFormatToMSDateFormatString(enImportDateFormats dateFormat) {
			switch (dateFormat) {
				case enImportDateFormats.MMDDYYYY_Dash:
				case enImportDateFormats.MMDDYYYY_Slash:
					return "MM/dd/yyyy";
				case enImportDateFormats.DDMMYYYY_Dash:
				case enImportDateFormats.DDMMYYYY_Period:
				case enImportDateFormats.DDMMYYYY_Slash:
					return "dd/MM/yyyy";
				case enImportDateFormats.YYYYMMDD_Dash:
				case enImportDateFormats.YYYYMMDD_Period:
				case enImportDateFormats.YYYYMMDD_Slash:
					return "yyyy/MM/dd";
			}
			throw new NotImplementedException("Invalid date format");
		}

		public static string ConvertDateToMSDateFormat(string date) {
			date = date.Replace('-', '/');
			date = date.Replace('.', '/');
			return date;
		}
		#endregion

		#region Other Methods
		public static object getUserSettingDefault(string settingName) {
			object settingObj = "";
			switch (settingName) {
				case "DefaultSearchBy":
					settingObj = "";
					break;
				case "DefaultSearchIn":
					settingObj = "";
					break;
				case "DefaultTab":
					settingObj = "0";
					break;
				case "DefaultView":
					settingObj = "0";
					break;
				default:
					settingObj = null;
					break;
			}
			return settingObj;
		}

		public static string getGroupSettingDefault(string settingName) {
			object settingObj = getSettingDefault(settingName);

			if (settingObj == null) {
				//A switch statement could be used here for settings that aren't related to normal system settings.
				return null;
			}

			return settingObj.ToString();
		}

		public static object getSettingDefault(string settingName) {
			object settingObj = "";
			switch (settingName) {
				case "Sync to Category":
					settingObj = "0";
					break;
				case "Business Title":
					settingObj = "NAVEX Global";
					break;
				case "Default Review Interval":
					settingObj = "12";
					break;
				case "Warn X Months before Due for Review":
					settingObj = "2";
					break;
				case "Use Water Mark":
					settingObj = "1";
					break;
				case "Water Mark Color":
					settingObj = "#edf0ff";
					break;
				case "Use Auto Reference Numbering":
					settingObj = "1";
					break;
				case "Auto Reference Numbering Start":
					settingObj = "1";
					break;
				case "Login Timeout":
					settingObj = "1800";
					break;
				case "Email Queue Load":
					settingObj = Config.getIniKey("EMAIL", "EmailQueueLoad");
					if (settingObj == null || (string) settingObj == "") {
						settingObj = "100";
					}
					break;
				case "USE BCC in Queue":
					settingObj = Config.getIniKey("EMAIL", "BulkUseBCC");
					if (settingObj == null || (string) settingObj == "") {
						settingObj = "0";
					}
					break;
				case "Users per BCC email":
					settingObj = Config.getIniKey("EMAIL", "UsersPerBCC");
					if (settingObj == null || (string) settingObj == "") {
						settingObj = "100";
					}
					break;
				case "Bulk Email Address":
					settingObj = Config.getIniKey("EMAIL", "BulkEmailAddress");
					break;
				case "Bulk Email Name":
					settingObj = Config.getIniKey("EMAIL", "BulkEmailName");
					if (settingObj == null || (string) settingObj == "") {
						settingObj = "Policy Manager Readers";
					}
					break;
				case "Use Bulk Mail":
					settingObj = Config.getIniKey("EMAIL", "UseBulk");
					if (settingObj == null || (string) settingObj == "") {
						settingObj = "1";
					}
					break;
				case "Active Directory Sync Queue Length":
					settingObj = "50";
					break;
				case "Active Directory Restore Deleted":
					settingObj = false;
					break;
				case "LoginURL":
				case "URLToProgram":
					settingObj = "";
					break;
				case "SMTP server":
					settingObj = "";
					break;
				case "SMTP port":
					settingObj = "0";
					break;
				case "SMTP Domain":
					settingObj = "";
					break;
				case "SMTP server account":
					settingObj = "";
					break;
				case "SMTP server password":
					settingObj = "";
					break;
				case "Sender email":
					settingObj = "";
					break;
				case "Send reminder interval":
					settingObj = "0";
					break;
				case "Server requires auth":
					settingObj = "";
					break;
				case "Send overdue reminder interval":
					settingObj = "0";
					break;
				case "Send reminder Start Time":
					settingObj = "";
					break;
				case "Change Password on First Login":
					settingObj = "0";
					break;
				case "Required Password Length":
					settingObj = "0";
					break;
				case "Numeric Character Count":
					settingObj = "0";
					break;
				case "Special Character Count":
					settingObj = "0";
					break;
				case "Uppercase Character Count":
					settingObj = "0";
					break;
				case "Use Electronic Signature":
					settingObj = "0";
					break;
				case "Public Access to Reader Comments":
					settingObj = "";
					break;
				case "Max Threads":
					settingObj = Config.getIniKey("EMAIL", "MaxThreads");
					if (settingObj == null || (string) settingObj == "") {
						settingObj = "1";
					}
					break;
				case "Process but do not email":
					settingObj = "0";
					break;
				case "Reference Number Display":
					settingObj = "0";
					break;
				case "Download Original":
					settingObj = "0";
					break;
				case "Drag Out":
					settingObj = "0";
					break;
				case "Login Logo Justification":
					settingObj = "center";
					break;
				case "Active Directory Delete Inactive":
					settingObj = false;
					break;
				case "Send Notification to Approvers":
					settingObj = "1";
					break;
				case "Use SSL":
					settingObj = "0";
					break;
				case "Task Summary Use Reminder Interval":
					settingObj = "1";
					break;
				case "Task Summary Reminder Interval":
				case "Task Summary Reminder Interval Contacts":
					settingObj = "0";
					break;
				case "Task Summary Use Send On":
				case "Task Summary Use Send On Contacts":
					settingObj = "0";
					break;
				case "Task Summary Send On Days":
				case "Task Summary Send On Days Contacts":
					settingObj = "0;1;2;3;4;5;6";
					break;
				case "Task Summary Frequency":
				case "Task Summary Frequency Contacts":
					settingObj = "";
					break;
				case "Task Summary Reminder Start Time":
				case "Task Summary Reminder Start Time Contacts":
					settingObj = "12:00";
					break;
				case "Overdue Tasks Use Reminder Interval":
					settingObj = "1";
					break;
				case "Overdue Tasks Send On Days":
					settingObj = "0;1;2;3;4;5;6";
					break;
				case "Overdue Tasks Reminder Start Time":
					settingObj = "12:00";
					break;
				case "FIPS Conversion":
					settingObj = "0";
					break;
				case "SAML Allowable Clock Skew":
					settingObj = 5;
					break;
				case "SAML RelayState Variable":
					settingObj = "RelayState";
					break;
				case "Send Task Alerts From":
					settingObj = enEmailSendTaskAlertsFrom.SYSTEM.StringValueOf();
					break;
				case "Filter users doc list by their departments":
					settingObj = 0;
					break;
				case "Individual Task Summary Only Period":
					settingObj = 1;
					break;
				case "User Import Report Only Displays Changes":
					settingObj = "0";
					break;
				case "Disable No Revision Necessary":
					settingObj = false;
					break;
				case "Replace Contents":
					settingObj = false;
					break;
				case "User Import Overwrite Manager":
					settingObj = false;
					break;
				case "Proxy Mark as Read":
					settingObj = false;
					break;
				case "Selected Method for Sending Emails":
					settingObj = 2;//default to send method : email server selection type is "Client Enters Details"
					break;
				case "Regulation Display Version":
				case "Regulation Display Status":
					settingObj = true;
					break;
				case "Display SubCategory Path Before Name":
					settingObj = false;
					break;
				case "Restrict Document Viewing to Users Sites":
					settingObj = 0;
					break;
				case "Suppress Initial Reader Task Emails":
					settingObj = 0;
					break;
				case "Suppress Initial Overdue Reader Task Emails":
					settingObj = 0;
					break;
				case "Escalation Summary Emails Enabled":
					settingObj = 1;
					break;
				case "Show Notification Messages To Site DCAs":
					settingObj = true;
					break;
				case "Show Notification Messages To IT":
					settingObj = true;
					break;
				case "Home Dashboard Enabled":
					settingObj = true;
					break;
				case "Allowed Upload Extensions":
					settingObj = "";
					break;
				case "GlobalDashboardEnabled":
					settingObj = true;
					break;
				case "UserDashboardVisibility":
					settingObj = enDashboardVisability.ALL;
					break;
				case "User Import Queue Length":
					settingObj = "500";
					break;
				case "User Import Ignore Blank Values":
					settingObj = true;
					break;
				default:
					settingObj = null;
					break;
			}
			return settingObj;
		}

		public static string getArrangeBy(string ab) {
			if (ab == null) {   //default to arrange by  DEPT
				return "dept";
			}
			int attemptedID = 0;
			int indexofColon = ab.IndexOf(':');
			string abStr = ab;
			string workflowStepID = null;
			if (indexofColon > 0) {
				//get everything before the colon
				abStr = ab.Substring(0, indexofColon);
				//if they have a : in the string, and after the string is not a number, return "dept"
				if (abStr == "workflowstep") {
					workflowStepID = ab.Split(':')[1];
				} else if (int.TryParse(ab.Substring(indexofColon + 1), out attemptedID) == false) {
					return "dept";
				}
			}
			switch (abStr) {
				case "dept":
					abStr = "dept";
					break;
				case "workflowstep":
					abStr = "workflowstep:" + workflowStepID;
					break;
				case "allcat":
					abStr = "allcat";
					break;
				case "cat":
					abStr = "cat:" + attemptedID.ToString();
					break;
				case "custom":
					abStr = "custom:" + attemptedID.ToString();
					break;
				case "documentstatus":
					abStr = "documentstatus";
					break;
				case "documentworkflowstep":
					abStr = "documentworkflowstep";
					break;
				case "library":
					abStr = "library";
					break;
				case "jobtitle":
					abStr = "jobtitle";
					break;
				case "departmentjobtitle":
					abStr = "departmentjobtitle";
					break;
				case "template":
					abStr = "template";
					break;
				default:
					abStr = "dept";
					break;
			}
			return abStr;
		}

		public static enGenericActionTypes GetGenericActionTypeByActionType(enActionType actionType) {
			switch (actionType) {
				case enActionType.APPROVERACCEPT:
				case enActionType.REVIEWERACCEPT:
				case enActionType.WRITERDONE:
				case enActionType.LINKREVIEWED:
					return enGenericActionTypes.ACCEPT;
				case enActionType.APPROVERREVISE:
				case enActionType.REVIEWERREVISE:
					return enGenericActionTypes.REVISE;
				case enActionType.APPROVERDECLINE:
				case enActionType.REVIEWERDECLINE:
					return enGenericActionTypes.DECLINE;
				case enActionType.READCANCEL:
					return enGenericActionTypes.CANCEL;
				case enActionType.READERDONE:
					return enGenericActionTypes.READ;
				case enActionType.NONE:
				case enActionType.EXPIREREVIEWED:
					return enGenericActionTypes.NONE;
				case enActionType.REGULATORYCOMPLIANCESET:
				case enActionType.REGULATIONDOCUMENTCREATED:
				case enActionType.CORRECTIVEACTIONDONE:
				case enActionType.CUSTOMREGULATIONTASKCOMPLETE:
					return enGenericActionTypes.COMPLETE;
				default:
					throw new Exception("Action type not yet implemented.");
			}
		}

		#endregion

	}

	#region Enumerations declared
	[TypeScriptModule("Constants")]
	public enum enToastType {
		Success = 0,
		Warning = 1,
		Danger = 2
	}

	[TypeScriptModule("Constants")]
	public enum enToastDuration {
		Short = 2000,
		Long = 5000
	}

	[TypeScriptModule("Constants")]
	public enum enHomeDashboardWidgetGroupType {
		Basic = 0,
		Custom = 1,
		Reports = 2
	}

	[TypeScriptModule("Constants")]
	public enum enHomeDashboardWidgetType {
		CompanyMessage = 0,
		Tasks = 1,
		SavedReport = 2,
		FavoriteDocuments = 3,
		RecentDocuments = 4,
		CategoryDocuments = 5,
		SiteMessage = 6,
		RecentlyPublished = 7,
	}

	[TypeScriptModule("Constants")]
	public enum enMultiLevelSelectBoxUseLevels {
		False,
		True,
		ReadOnly
	}

	[TypeScriptModule("Constants")]
	public enum enMultiLevelSelectBoxShowDueDates {
		False,
		True,
		ReadOnly
	}

	[TypeScriptModule("Constants")]
	public enum enRegKeyItemType {
		NOT_APPLICABLE,
		LICENSE_TYPE,
		ADDITIONAL_FEATURES,
		REQUIRES_APPROVAL,
		OBSOLETE

	}

	[TypeScriptModule("Constants")]
	public enum enRegKeyItemDataType {
		[DescriptionAttribute("int")]
		INTEGER,
		[DescriptionAttribute("bool")]
		BOOLEAN,
		[DescriptionAttribute("string")]
		STRING,
		[DescriptionAttribute("date")]
		DATE,
		[DescriptionAttribute("list")]
		LIST,
		[DescriptionAttribute("languageList")]
		LANGUAGE_LIST
	}

	[TypeScriptModule("Constants")]
	public enum enCaseIntegrationSystem {
		NONE = 0,
		IEM = 1,
		Integrilink = 2
	}

	[TypeScriptModule("Constants")]
	public enum enCaseCreationStatus {
		AllFailed = -1,
		InitialAttempt = 1,
		InQueue = 2,
		Stopped = 3,
		Successful = 4
	}

	[TypeScriptModule("Constants")]
	public enum enCaseCreationFailCodes {
		All = -1,
		Resolved = 1,
		Other = 2,
		ConnectionError = 3,
		InvalidData = 4,
		CaseCreationDisabled = 5
	}

	[TypeScriptModule("Constants")]
	public enum enBulkEditType { REGULAR = 0, TASKS = 1, BULKIMPORT = 2 };

	[TypeScriptModule("Constants")]
	public enum enReportArea {
		DeprecatedReports = 0,
		SavedReports = 1,
		Personal = 2,
		DocumentTasks = 3,
		UserTasks = 4,
		DocumentReports = 5,
		UserReports = 6,
		QuizReports = 7,
		Admin = 8,
		Other = 9,
		ExceptionReports = 10,
		UserGroupTasks = 11,
		ComplianceReports = 12
	}

	[TypeScriptModule("Constants")]
	public enum enReportType {
		DocumentTasks = 1,
		UserTasks = 2,
		DocumentsPeriodicReview = 3,
		DocumentsUpdateLinks = 4,
		DocumentAssignments = 5,
		DocumentCountOwner = 6,
		DocumentsAccessed = 7,
		DocumentDurationInWorkflow = 8,
		LinkedDocuments = 9,
		DocumentsDateRange = 10,
		DocumentsApprovedSpecificDate = 11,
		UserAssignments = 12,
		UserDocumentAccessedReport = 13,
		CancelledMarkAsRead = 14,
		UserPermissions = 15,
		DocumentQuizReport = 16,
		UserQuizReport = 17,
		FailedLogins = 18,
		UsersCurrentlyLoggedIn = 19,
		UsersUpdateLinks = 20,
		UsersPeriodicReview = 21,
		AllUserTasks = 22,
		AllDocumentTasks = 23,
		PrintMultiple = 24,
		UserQuizReportPersonal = 25,
		UsersPeriodicReviewPersonal = 26,
		UserTasksPersonal = 27,
		AllUserTasksPersonal = 28,
		Other = 29,
		UserQuizCertificate = 30,
		ExceptionsByDocument = 31,
		ChangeSummary = 32,
		UsersWithEmailFailure = 33,
		EmailFailuresByDocument = 34,
		DedicatedLicenses = 35,
		UserGroupTasks = 36,
		ComplianceOverview = 37,
		ExportDocuments = 38,
		PrintDocumentList = 39,
		TaskByDocumentCurrent = 40,
		TaskByDocumentAll = 41,
		TaskByUserCurrent = 42,
		TaskByUserAll = 43
	}

	[TypeScriptModule("Constants")]
	public enum enEmailType {
		TASK_SUMMARY,
		OVERDUE
	}

	[TypeScriptModule("Constants")]
	public enum enWelcomeEmailSendTo {
		CREATED_SINCE_LAST_SEND = 0,
		EVERYONE = 1,
		NOT_LOGGED_IN = 2,
		NOT_LOGGED_IN_SINCE = 3
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enDocumentRelationType {
		NONE = 0X00,
		MASTERDOCUMENT = 0X01,
		LOCALIZEDCOPY = 0x02,
		LOCALIZEDCOPYSYNCED = 0x04,
		LOCALIZEDCOPYSYNCEDAUTOASSIGN = 0x08,
		LOCALIZEDCOPYSYNCEDAUTOASSIGNINHERITREAD = 0x10
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentImportResult {
		SUCCESS = 1,
		NO_HEADERS_TEMPLATE_NOT_WORD_DOC = 2,
		NO_HEADERS_DOC_NOT_WORD_DOC = 3,
		NO_HEADERS_CANNOT_MODIFY_DOC = 4,
		NO_HEADERS_HEADER_NOT_ASPOSE_EDITABLE = 5,
		NO_HEADERS_UNKNOWN_ERROR = 6,
		INVALID_CHARACTERS = 7,
		FILE_IS_ZIP = 8,
		DOCUMENT_LIMIT_REACHED = 9,
		FAILED = 10,
		DISABLEDBYCONFIG = 11,
		CANCELED = 12
	}

	[TypeScriptModule("Constants")]
	public enum enFieldAction {
		FIELDNAME,
		SETFIELD
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentLinkTypes {
		[DescriptionAttribute("Regular")]
		Regular,
		[DescriptionAttribute("Email")]
		Email,
		[DescriptionAttribute("InsertedLink")]
		InsertedLink,
		[DescriptionAttribute("AttachedLink")]
		AttachedLink
	};

	[TypeScriptModule("Constants")]
	public enum enDocumentOwnerTypes {
		IGNORE = -1,
		USERS_WITH_ROLE = 0,
		CUSTOM_USERS = 1,
		ALL_USERS = 2
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentNotificationLevel {
		MINIMUM = 10,
		MEDIUM = 20,
		HIGH = 30,
		MAXIMUM = 40
	}

	[TypeScriptModule("Constants")]
	public enum enApplicationOptions {
		[DescriptionAttribute("dbHost")]
		DBHOST,
		[DescriptionAttribute("dbType")]
		DBTYPE,
		[DescriptionAttribute("dbSimpleType")]
		DBSIMPLETYPE,
		[DescriptionAttribute("dbTypeLongName")]
		DBTYPELONGNAME,
		[DescriptionAttribute("dbName")]
		DBNAME,
		[DescriptionAttribute("dbDefaultName")]
		DBDEFAULTNAME,
		[DescriptionAttribute("dbUsername")]
		DBUSERNAME,
		[DescriptionAttribute("dbPass")]
		DBPASS,
		[DescriptionAttribute("dbPort")]
		DBPORT,
		[DescriptionAttribute("dbBackupOption")]
		DBBACKUPOPTION,
		[DescriptionAttribute("SessionDuration")]
		SESSIONDURATION,
		[DescriptionAttribute("DataFilesDefaultRootPath")]
		DATAFILESDEFAULTROOTPATH,
		[DescriptionAttribute("AppDefaultLanguage")]
		DEFAULTLANGUAGE,
		[DescriptionAttribute("AppDefaultDateFormat")]
		DEFAULTDATEFORMAT,
		[DescriptionAttribute("AppDefaultTimeFormat")]
		DEFAULTTIMEFORMAT,
		[DescriptionAttribute("AppDefaultTimeZone")]
		DEFAULTTIMEZONE,
		[DescriptionAttribute("AppDefaultTimeZoneArrayTimeZone")]
		TIMEZONEARRAYTZ,
		[DescriptionAttribute("dbUse16BitChars")]
		UNICODECHARS,
		[DescriptionAttribute("PDFConverterInstalled")]
		PDFCONVERTERINSTALLED,
		[DescriptionAttribute("ViewModuleInstalled")]
		VIEWMODULEINSTALLED,
		[DescriptionAttribute("ActiveDirectoryAuthInstalled")]
		ADAUTHINSTALLED,
		[DescriptionAttribute("ISYSInstalled")]
		ISYSINSTALLED,
		[DescriptionAttribute("Theme")]
		THEME,
		[DescriptionAttribute("MobileThemeHighlightBackground")]
		MOBILE_THEME_HIGHLIGHT_BACKGROUND,
		[DescriptionAttribute("MobileThemeHighlightText")]
		MOBILE_THEME_HIGHLIGHT_TEXT,
		[DescriptionAttribute("MobileThemeButtonPrimaryBackground")]
		MOBILE_THEME_BUTTON_PRIMARY_BACKGROUND,
		[DescriptionAttribute("MobileThemeButtonPrimaryText")]
		MOBILE_THEME_BUTTON_PRIMARY_TEXT,
		[DescriptionAttribute("Theme Last Modified Stamp")]
		THEME_LAST_MODIFIED_STAMP,
		[DescriptionAttribute("dbIntegratedSecurity")]
		DBINTEGRATEDSECURITY,
		[DescriptionAttribute("applicationid")]
		APPLICATIONID,
		[DescriptionAttribute("topLeftICON")]
		TOP_LEFT_ICON,
		[DescriptionAttribute("enableCustomBanner")]
		ENABLE_CUSTOM_BANNER,
		[DescriptionAttribute("showBannerOnDesktop")]
		SHOW_BANNER_DESKTOP,
		[DescriptionAttribute("showBannerOnMobile")]
		SHOW_BANNER_MOBILE,
		[DescriptionAttribute("showBannerOnApp")]
		SHOW_BANNER_APP,
		[DescriptionAttribute("bannerHeight")]
		BANNER_HEIGHT,
		[DescriptionAttribute("bannerLogo")]
		BANNER_LOGO,
		[DescriptionAttribute("bannerRepeating")]
		BANNER_REPEATING,
		[DescriptionAttribute("bannerLeftSide")]
		BANNER_LEFTSIDE,
		[DescriptionAttribute("bannerLogoURL")]
		BANNER_LOGOURL,
		[DescriptionAttribute("bannerLogoHelpText")]
		BANNER_LOGO_HELPTEXT,
		[DescriptionAttribute("bannerPosFromLeft")]
		BANNER_POS_FROM_LEFT,
		[DescriptionAttribute("bannerPosHorzOffset")]
		BANNER_POS_HORZ_OFFSET,
		[DescriptionAttribute("bannerPosVertOffset")]
		BANNER_POS_VERT_OFFSET,
		[DescriptionAttribute("enableLogoArea")]
		ENABLE_LOGO_AREA
	}

	[TypeScriptModule("Constants")]
	public enum enAsposeDocumentType {
		UNKNOWN,
		WORD,
		PDF,
		EXCEL,
		HTML, // Not ready to handle Inserted Fields, Inserted Links, and Inserted Logos in HTML yet. Started working on it PPM 8.5 but postponed it. -- Anthony T. (See AsposeManager_HTML.cs for more details)
		NOT_SET
	}

	[TypeScriptModule("Constants")]
	public enum enAsposeDocumentSaveType {
		[DescriptionAttribute("doc")]
		DOC,
		[DescriptionAttribute("docx")]
		DOCX,
		[DescriptionAttribute("jpg")]
		JPG,
		[DescriptionAttribute("pdf")]
		PDF,
		[DescriptionAttribute("txt")]
		TXT
	}

	[TypeScriptModule("Constants")]
	public enum enDefaultSearchBy {
		[DescriptionAttribute("SelectedStatus")]
		SELECTEDSTATUS,
		[DescriptionAttribute("CurrentArrangement")]
		CURRENTARRANGEMENT,
		[DescriptionAttribute("EntireLibrary")]
		ENTIRELIBRARY
	};

	[TypeScriptModule("Constants")]
	public enum enDefaultSearchIn {
		[DescriptionAttribute("title")]
		TITLE,
		[DescriptionAttribute("datatext")]
		FULLTEXT,
		[DescriptionAttribute("keywords")]
		KEYWORDS,
		[DescriptionAttribute("referencenumber")]
		REFERENCENUMBER,
		[DescriptionAttribute("all")]
		ALLOFTHEABOVE
	};

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enDocumentStatus {
		[DescriptionAttribute("draft")]
		DRAFT = 0x01,
		[DescriptionAttribute("processreview")]
		REVIEW = 0x02,
		[DescriptionAttribute("processapprove")]
		APPROVAL = 0x04,
		[DescriptionAttribute("pending")]
		PENDING = 0x08,
		[DescriptionAttribute("approved")]
		APPROVED = 0x10,
		[DescriptionAttribute("archived")]
		ARCHIVED = 0x20,
		[DescriptionAttribute("predraft")]
		PREDRAFT = 0x40
	}


	[TypeScriptModule("Constants")]
	public enum enLinkedDocumentType {
		[DescriptionAttribute("referenced")]
		REFERENCED,
		[DescriptionAttribute("replaced")]
		REPLACED,
		[DescriptionAttribute("linked")]
		LINKED,
		[DescriptionAttribute("localizedcopy")]
		LOCALIZEDCOPY
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentFilterMode {

		[DescriptionAttribute("docsiproxy")]
		DOCSIPROXY,
		[DescriptionAttribute("none")]
		NONE,
		[DescriptionAttribute("allbutarchived")]
		ALLBUTARCHIVED,
		[DescriptionAttribute("favorite")]
		FAVORITE,
		[DescriptionAttribute("workflowStep")]
		WORKFLOWSTEP,
		[DescriptionAttribute("docsiworkflowStep")]
		DOCSIWORKFLOWSTEP,
		[DescriptionAttribute("docstatus")]
		DOCSTATUS,
		[DescriptionAttribute("recent")]
		RECENT,
		[DescriptionAttribute("allbutpredraft")]
		ALLBUTPREDRAFT,
		[DescriptionAttribute("doclistbycat")]
		DOCLISTBYCAT
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentSignatureType {
		NORMAL = 1,
		ELECTRONICALLYSIGNED = 2,
		SIGNEDBYPROXY = 3,
		ELECTRONICALLYSIGNEDBYPROXY = 4,
		DIGITALLYSIGNED = 5
	}

	[TypeScriptModule("Constants")]
	public enum enIniBoolValue {
		INI_True,
		INI_False,
		INI_NotSet
	}

	[TypeScriptModule("Constants")]
	public enum enWordFormattedDateType {
		Approved,
		Archived,
		Created,
		Effective,
		Expired,    //Use NextPeriodicReviewDate instead of this.
		NextReview, //Use NextPeriodicReviewDate instead of this.
		Submitted,
		LastPeriodicReviewDate,
		NextPeriodicReviewDate,
		Original_Creation_Date,
		Date_Last_Modified
	}
	/// <summary>DO NOT CHANGE THESE VALUES.  Doing so will cause new snapshots to be created for any documents containing your changes as inserted fields
	/// Also, please do not use an underscore (_) character in the Description Attribute of these fields.</summary>
	[TypeScriptModule("Constants")]
	public enum enWordFields {
		[DescriptionAttribute("Undefined")]
		Undefined = 0,
		[DescriptionAttribute("Business Title")]
		Business_Title = 1,
		[DescriptionAttribute("Document Title")]
		Document_Title = 2,
		[DescriptionAttribute("Next Review Date")]
		Next_Review_Date = 3,
		[DescriptionAttribute("Date Expires")]
		Date_Expires = 4,
		[DescriptionAttribute("Date Created")]
		Date_Created = 5,
		[DescriptionAttribute("Date Approved")]
		Date_Approved = 6,
		[DescriptionAttribute("Reference #")]
		Reference_No = 7,
		[DescriptionAttribute("Version")]
		Version = 8,
		[DescriptionAttribute("Supersedes")]
		Supersedes = 9,
		[DescriptionAttribute("Department(s)")]
		Departments = 10,
		[DescriptionAttribute("site Name")]
		site_Name = 11,
		[DescriptionAttribute("Effective Date")]
		Effective_Date = 12,
		[DescriptionAttribute("Date Submitted")]
		Date_Submitted = 13,
		[DescriptionAttribute("Category Titles")]
		Category_Titles = 14,
		[DescriptionAttribute("PO Both")]
		PO_Both = 15,
		[DescriptionAttribute("PO Full Name")]
		PO_Full_Name = 16,
		[DescriptionAttribute("PO Job Title")]
		PO_Job_Title = 17,
		[DescriptionAttribute("PO Department")]
		PO_Department = 18,
		[DescriptionAttribute("RV Full Name")]
		RV_Full_Name = 19,
		[DescriptionAttribute("RV Job Title")]
		RV_Job_Title = 20,
		[DescriptionAttribute("RV Both")]
		RV_Both = 21,
		[DescriptionAttribute("RV Department")]
		RV_Department = 22,
		[DescriptionAttribute("AP Full Name")]
		AP_Full_Name = 23,
		[DescriptionAttribute("AP Job Title")]
		AP_Job_Title = 24,
		[DescriptionAttribute("AP Both")]
		AP_Both = 25,
		[DescriptionAttribute("AP Department")]
		AP_Department = 26,
		[DescriptionAttribute("Required Readers")]
		Required_Readers = 27,
		[DescriptionAttribute("RD Full Name")]
		RD_Full_Name = 28,
		[DescriptionAttribute("RD Job Title")]
		RD_Job_Title = 29,
		[DescriptionAttribute("RD Both")]
		RD_Both = 30,
		[DescriptionAttribute("RD Department")]
		RD_Department = 31,
		[DescriptionAttribute("Keywords")]
		Keywords = 32,
		[DescriptionAttribute("Option")]
		Option = 33,
		[DescriptionAttribute("PPMDB")]
		PPMDB = 34,
		[DescriptionAttribute("Date Archived")]
		Date_Archived = 35,
		[DescriptionAttribute("WR Full Name")]
		Writers_Full_Name = 36,
		[DescriptionAttribute("WR Job Title")]
		Writers_Job_Title = 37,
		[DescriptionAttribute("WR Both")]
		Writers_Both = 38,
		[DescriptionAttribute("WR Department")]
		Writers_Department = 39,
		[DescriptionAttribute("Date Last Reviewed")]
		Date_Last_Reviewed = 40,
		[DescriptionAttribute("Original Creation Date")]
		Original_Creation_Date = 41,
		[DescriptionAttribute("Current Major Version Changes")]
		CurrentMajorVersionChanges = 42,
		[DescriptionAttribute("Originating Department")]
		OriginatingDepartment = 43,
		[DescriptionAttribute("Last Periodic Review Date")]
		LastPeriodicReviewDate = 44,
		[DescriptionAttribute("Next Periodic Review Date")]
		NextPeriodicReviewDate = 45,
		[DescriptionAttribute("PO LNFN")]
		PO_LastNameFirstName = 46,
		[DescriptionAttribute("RV LNFN")]
		RV_LastNameFirstName = 47,
		[DescriptionAttribute("AP LNFN")]
		AP_LastNameFirstName = 48,
		[DescriptionAttribute("RD LNFN")]
		RD_LastNameFirstName = 49,
		[DescriptionAttribute("WR LNFN")]
		Writers_LastNameFirstName = 50,
		[DescriptionAttribute("AV Both")]
		AV_Both = 51,
		[DescriptionAttribute("AV Full Name")]
		AV_Full_Name = 52,
		[DescriptionAttribute("AV Job Title")]
		AV_Job_Title = 53,
		[DescriptionAttribute("AV Department")]
		AV_Department = 54,
		[DescriptionAttribute("AV LNFN")]
		AV_LastNameFirstName = 55,
		[DescriptionAttribute("DC Both")]
		DC_Both = 56,
		[DescriptionAttribute("DC Full Name")]
		DC_Full_Name = 57,
		[DescriptionAttribute("DC Job Title")]
		DC_Job_Title = 58,
		[DescriptionAttribute("DC Department")]
		DC_Department = 59,
		[DescriptionAttribute("DC LNFN")]
		DC_LastNameFirstName = 60,
		[DescriptionAttribute("AP Groupname")]  //Approver
		AP_GroupName_Only = 66,
		[DescriptionAttribute("AV Groupname")]  //Allowed Viewer
		AV_GroupName_Only = 67,
		[DescriptionAttribute("RD Groupname")]
		RD_GroupName_Only = 69,
		[DescriptionAttribute("RV Groupname")]  //Reviewer
		RV_GroupName_Only = 70,
		[DescriptionAttribute("WR Groupname")]  //Writer
		Writers_GroupName_Only = 71,
		[DescriptionAttribute("AP All users Full Name")]
		AP_ALL_Full_Name = 72,
		[DescriptionAttribute("AP All users Job Title")]
		AP_ALL_Job_Title = 73,
		[DescriptionAttribute("AP All users Both")]
		AP_ALL_Both = 74,
		[DescriptionAttribute("AP All users Department")]
		AP_ALL_Department = 75,
		[DescriptionAttribute("AP All users LNFN")]
		AP_ALL_LastNameFirstName = 76,
		[DescriptionAttribute("AV All users Both")]
		AV_ALL_Both = 77,
		[DescriptionAttribute("AV All users Full Name")]
		AV_ALL_Full_Name = 78,
		[DescriptionAttribute("AV All users Job Title")]
		AV_ALL_Job_Title = 79,
		[DescriptionAttribute("AV All users Department")]
		AV_ALL_Department = 80,
		[DescriptionAttribute("AV All users LNFN")]
		AV_ALL_LastNameFirstName = 81,
		[DescriptionAttribute("RD All users Full Name")]
		RD_ALL_Full_Name = 87,
		[DescriptionAttribute("RD All users Job Title")]
		RD_ALL_Job_Title = 88,
		[DescriptionAttribute("RD All users Both")]
		RD_ALL_Both = 89,
		[DescriptionAttribute("RD All users Department")]
		RD_ALL_Department = 90,
		[DescriptionAttribute("RD All users LNFN")]
		RD_ALL_LastNameFirstName = 91,
		[DescriptionAttribute("RV All users Full Name")]
		RV_ALL_Full_Name = 92,
		[DescriptionAttribute("RV All users Job Title")]
		RV_ALL_Job_Title = 93,
		[DescriptionAttribute("RV All users Both")]
		RV_ALL_Both = 94,
		[DescriptionAttribute("RV All users Department")]
		RV_ALL_Department = 95,
		[DescriptionAttribute("RV All users LNFN")]
		RV_ALL_LastNameFirstName = 96,
		[DescriptionAttribute("WR All users Full Name")]
		Writers_ALL_Full_Name = 97,
		[DescriptionAttribute("WR All users Job Title")]
		Writers_ALL_Job_Title = 98,
		[DescriptionAttribute("WR All users Both")]
		Writers_ALL_Both = 99,
		[DescriptionAttribute("WR All users Department")]
		Writers_ALL_Department = 100,
		[DescriptionAttribute("WR All users LNFN")]
		Writers_ALL_LastNameFirstName = 101,
		[DescriptionAttribute("AP GroupNames and All users Full Name")]
		AP_Groups_AND_ALL_Full_Name = 102,
		[DescriptionAttribute("AP GroupNames and All users Job Title")]
		AP_Groups_AND_ALL_Job_Title = 103,
		[DescriptionAttribute("AP GroupNames and All users Both")]
		AP_Groups_AND_ALL_Both = 104,
		[DescriptionAttribute("AP GroupNames and All users Department")]
		AP_Groups_AND_ALL_Department = 105,
		[DescriptionAttribute("AP GroupNames and All users LNFN")]
		AP_Groups_AND_ALL_LastNameFirstName = 106,
		[DescriptionAttribute("AV GroupNames and All users Both")]
		AV_Groups_AND_ALL_Both = 107,
		[DescriptionAttribute("AV GroupNames and All users Full Name")]
		AV_Groups_AND_ALL_Full_Name = 108,
		[DescriptionAttribute("AV GroupNames and All users Job Title")]
		AV_Groups_AND_ALL_Job_Title = 109,
		[DescriptionAttribute("AV GroupNames and All users Department")]
		AV_Groups_AND_ALL_Department = 110,
		[DescriptionAttribute("AV GroupNames and All users LNFN")]
		AV_Groups_AND_ALL_LastNameFirstName = 111,
		[DescriptionAttribute("RD GroupNames and All users Full Name")]
		RD_Groups_AND_ALL_Full_Name = 117,
		[DescriptionAttribute("RD GroupNames and All users Job Title")]
		RD_Groups_AND_ALL_Job_Title = 118,
		[DescriptionAttribute("RD GroupNames and All users Both")]
		RD_Groups_AND_ALL_Both = 119,
		[DescriptionAttribute("RD GroupNames and All users Department")]
		RD_Groups_AND_ALL_Department = 120,
		[DescriptionAttribute("RD GroupNames and All users LNFN")]
		RD_Groups_AND_ALL_LastNameFirstName = 121,
		[DescriptionAttribute("RV GroupNames and All users Full Name")]
		RV_Groups_AND_ALL_Full_Name = 122,
		[DescriptionAttribute("RV GroupNames and All users Job Title")]
		RV_Groups_AND_ALL_Job_Title = 123,
		[DescriptionAttribute("RV GroupNames and All users Both")]
		RV_Groups_AND_ALL_Both = 124,
		[DescriptionAttribute("RV GroupNames and All users Department")]
		RV_Groups_AND_ALL_Department = 125,
		[DescriptionAttribute("RV GroupNames and All users LNFN")]
		RV_Groups_AND_ALL_LastNameFirstName = 126,
		[DescriptionAttribute("WR GroupNames and All users Full Name")]
		Writers_Groups_AND_ALL_Full_Name = 127,
		[DescriptionAttribute("WR GroupNames and All users Job Title")]
		Writers_Groups_AND_ALL_Job_Title = 128,
		[DescriptionAttribute("WR GroupNames and All users Both")]
		Writers_Groups_AND_ALL_Both = 129,
		[DescriptionAttribute("WR GroupNames and All users Department")]
		Writers_Groups_AND_ALL_Department = 130,
		[DescriptionAttribute("WR GroupNames and All users LNFN")]
		Writers_Groups_AND_ALL_LastNameFirstName = 131,
		[DescriptionAttribute("Date Last Modified")]
		Date_Last_Modified = 139,
		[DescriptionAttribute("Document Status")]
		Document_Status = 140,
		#region Actual Approver (AAP)
		//[DescriptionAttribute("AAP Full Name")]
		//AAP_Full_Name = 141,
		//[DescriptionAttribute("AAP Job Title")]
		//AAP_Job_Title = 142,
		//[DescriptionAttribute("AAP Both")]
		//AAP_Both = 143,
		//[DescriptionAttribute("AAP Department")]
		//AAP_Department = 144,
		//[DescriptionAttribute("AAP LNFN")]
		//AAP_LastNameFirstName = 145,
		//		[DescriptionAttribute("AAP Groupname")]  //Approver
		//		AAP_GroupName_Only = 146,
		[DescriptionAttribute("AAP All users Full Name")]
		AAP_ALL_Full_Name = 147,
		[DescriptionAttribute("AAP All users Job Title")]
		AAP_ALL_Job_Title = 148,
		[DescriptionAttribute("AAP All users Both")]
		AAP_ALL_Both = 149,
		[DescriptionAttribute("AAP All users Department")]
		AAP_ALL_Department = 150,
		[DescriptionAttribute("AAP All users LNFN")]
		AAP_ALL_LastNameFirstName = 151,
		//[DescriptionAttribute("AAP GroupNames and All users Full Name")]
		//AAP_Groups_AND_ALL_Full_Name = 152,
		//[DescriptionAttribute("AAP GroupNames and All users Job Title")]
		//AAP_Groups_AND_ALL_Job_Title = 153,
		//[DescriptionAttribute("AAP GroupNames and All users Both")]
		//AAP_Groups_AND_ALL_Both = 154,
		//[DescriptionAttribute("AAP GroupNames and All users Department")]
		//AAP_Groups_AND_ALL_Department = 155,
		//[DescriptionAttribute("AAP GroupNames and All users LNFN")]
		//AAP_Groups_AND_ALL_LastNameFirstName = 156
		[DescriptionAttribute("AAP Actions Full Name")]
		AAP_Actions_Full_Name = 157,
		[DescriptionAttribute("AAP Actions Job Title")]
		AAP_Actions_Job_Title = 158,
		[DescriptionAttribute("AAP Actions Both")]
		AAP_Actions_Both = 159,
		[DescriptionAttribute("AAP Actions Department")]
		AAP_Actions_Department = 160,
		[DescriptionAttribute("AAP Actions LNFN")]
		AAP_Actions_LastNameFirstName = 161

		#endregion Actual Approver (AAP)
	}
	//!!!*** ALERT ***!!!DO NOT CHANGE THESE VALUES (you Can add to them, though).  
	//Doing so will cause new snapshots to be created for any documents containing your changes as inserted fields
	// Remember, please do not use an underscore (_) character in the Description Attribute of these fields!
	//Also, don't add any wierd characters, like !@#$%^&*().  Just use the letters of the alphabet, please.
	//Note: this note applies to enWordFields as well as enWordDateFields....anything that starts with enWord*, actually.

	[TypeScriptModule("Constants")]
	public enum enWordFieldPrefixes {
		[DescriptionAttribute("AAP ALL ")]
		ActualApprovers,
		[DescriptionAttribute("AAP Actions ")]
		ActualApproversWithDates,
		[DescriptionAttribute("OPT_")]
		Categories
	}

	[TypeScriptModule("Constants")]
	public enum enWordDateFields {
		[DescriptionAttribute("Short Month")]
		SHORT_MONTH,
		[DescriptionAttribute("Long Month")]
		LONG_MONTH,
		[DescriptionAttribute("Short Day")]
		SHORT_DAY,
		[DescriptionAttribute("Long Day")]
		LONG_DAY,
		[DescriptionAttribute("Two Digit Year")]
		TWO_DIGIT_YEAR,
		[DescriptionAttribute("Full Year")]
		FULL_YEAR
	}

	[TypeScriptModule("Constants")]
	public enum enWordPageFields {
		[DescriptionAttribute("Page Numbering")]
		PAGE_NUMBERING,
		[DescriptionAttribute("Page")]
		PAGE
	}

	[TypeScriptModule("Constants")]
	public enum enWordFieldsWithData {
		[DescriptionAttribute("OPT_")]
		ValuesByComma,
		[DescriptionAttribute("OPT_Title_")]
		Name,
		[DescriptionAttribute("OPT_HRt_")]
		ValuesByHRt,
		[DescriptionAttribute("OPT_Descr_")]
		Descriptions,
		[DescriptionAttribute("OPT_ValueDescr_")]
		ValuesAndDescriptions,
		[DescriptionAttribute("SiteImageID_")]
		Site_Image_ID,
		[DescriptionAttribute("CorpImageID_")]
		Corporate_Image_ID
	}

	[TypeScriptModule("Constants")]
	public enum enShowUserDetailsBy {
		ShowAllUsersBy_LNFN,
		ShowAllUsersBy_FNLN,
		ShowAllUsersBy_JobTitles,
		ShowAllUsersBy_Departments,
		ShowAllUsersBy_FNLN_AndJT,
		ShowGroupNamesAndAllUsersBy_LNFN,
		ShowGroupNamesAndAllUsersBy_FNLN,
		ShowGroupNamesAndAllUsersBy_JobTitles,
		ShowGroupNamesAndAllUsersBy_Departments,
		ShowGroupNamesAndAllUsersBy_FNLN_AndJT,
		SpecifiedUsers_By_LNFN,
		SpecifiedUsers_By_FNLN,
		SpecifiedUsers_By_JobTitles,
		SpecifiedUsers_By_Departments,
		SpecifiedUsers_By_FNLN_AndJT,
		ShowGroupNamesOnly,
		ShowClientApproverAccountName,
		ShowClientApproverAccountAddress,
		ShowClientApproverAccountCity,
		ShowClientApproverAccountState,
		ShowClientApproverAccountPostalCode,
		ShowClientApproverAccountCountry,
		ShowUsersAndDatesBy_LNFN,
		ShowUsersAndDatesBy_FNLN,
		ShowUsersAndDatesBy_JobTitles,
		ShowUsersAndDatesBy_Departments,
		ShowUsersAndDatesBy_FNLN_AndJT
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enStatus { //Allready all caps, no need for DescriptionAttribute?
		ACTIVE = 0x01,
		ARCHIVED = 0x02,
		DELETED = 0x04
	}

	[TypeScriptModule("Constants")]
	public enum enDisplayType {
		[DescriptionAttribute("noHeader")]
		NOHEADER,
		[DescriptionAttribute("department")]
		DEPARTMENT,
		[DescriptionAttribute("user")]
		USER,
		[DescriptionAttribute("noDocumentHeader")]
		NODOCUMENTHEADER,
		[DescriptionAttribute("web")]
		WEB,
		[DescriptionAttribute("AllSites")]
		ALLSITES,
		[DescriptionAttribute("tree")]
		TREE,
		[DescriptionAttribute("siteHeader")]
		SITEHEADER,
		[DescriptionAttribute("document")]
		DOCUMENT,
		[DescriptionAttribute("documentCounts")]
		DOCUMENTCOUNTS,
		[DescriptionAttribute("category")]
		CATEGORY
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentViewType {
		[DescriptionAttribute("public")]
		PUBLIC = 0,
		[DescriptionAttribute("private")]
		PRIVATE = 1,
		[DescriptionAttribute("specified")]
		SPECIFIED = 2,
		[DescriptionAttribute("specified restricted")]
		SPECIFIEDRESTRICTED = 3
	}

	[TypeScriptModule("Constants")]
	public enum enDBSelectFields {
		CORE_FIELDS,
		ALL_FIELDS,
		CORE_EXTENDED,
		ALL_EXTENDED,
		CRITICAL_FIELDS,
		CORE_EXTENDED_REPORT,
		CORE_REPORT
	}

	[TypeScriptModule("Constants")]
	public enum enAssignmentType {
		[DescriptionAttribute("none")]
		NONE = 0,
		[DescriptionAttribute("reviewer")]
		REVIEWER = 1,
		[DescriptionAttribute("approver")]
		APPROVER = 2,
		[DescriptionAttribute("writer")]
		WRITER = 3,
		[DescriptionAttribute("require")]
		REQUIREDREADER = 4,
		[DescriptionAttribute("allow")]
		ALLOWEDREADER = 5,
		[DescriptionAttribute("in")]
		IN = 6,
		[DescriptionAttribute("review linked")]
		REVIEWLINKED = 7,
		[DescriptionAttribute("review expired")]
		REVIEWEXPIRE = 8,
		[DescriptionAttribute("reassign owner")]
		REASSIGNOWNER = 9,
		[DescriptionAttribute("make comment")]
		MAKECOMMENT = 10,
		[DescriptionAttribute("favorite")]
		FAVORITE = 11,
		[DescriptionAttribute("allowed owner")]
		ALLOWEDOWNER = 12,
		[DescriptionAttribute("client approver")]
		CLIENTAPPROVER = 13,
		[DescriptionAttribute("document owner")]
		DOCUMENTOWNER = 14,
		[DescriptionAttribute("account representative")]
		ACCOUNTREPRESENTATIVE = 15,
		[DescriptionAttribute("archived")]
		ARCHIVED = 16,
		[DescriptionAttribute("dca")]
		DCA = 17,
		[DescriptionAttribute("hr")]
		HR = 18,
		[DescriptionAttribute("it")]
		IT = 19,
		[DescriptionAttribute("cat")]
		CATEGORYOWNER = 20,
		[DescriptionAttribute("template")]
		TEMPLATE = 21,
		[DescriptionAttribute("proxyauthor")]
		PROXYAUTHOR = 22,
		[DescriptionAttribute("deptmanager")]
		DEPTMANAGER = 23,
		[DescriptionAttribute("reportmanager")]
		REPORTMANAGER = 24,
		[DescriptionAttribute("view")]
		VIEW = 25,
		[DescriptionAttribute("pending")]
		PENDING = 26,
		[DescriptionAttribute("deptwithsubsmanager")]
		DEPTWITHSUBSMANAGER = 27,
		[DescriptionAttribute("notifydocumentavailable")]
		NOTIFYDOCUMENTAVAILABLE = 28,
		[DescriptionAttribute("ownerisapprover")]
		OWNERISAPPROVER = 29,
		[DescriptionAttribute("viewdocsalldepts")]
		VIEWDOCSALLDEPARTMENTS = 30,
		[DescriptionAttribute("casemanager")]
		CASEMANAGER = 31,
		[DescriptionAttribute("updatedocument")]
		UPDATEDOCUMENT = 32,
		[DescriptionAttribute("accountmanager")]
		ACCOUNTMANAGER = 33,
		[DescriptionAttribute("customquiztask")]
		CUSTOMQUIZTASK = 34,
		[DescriptionAttribute("predraft")]
		PREDRAFT = 35,
		[DescriptionAttribute("contact")]
		CONTACT = 36,
		[DescriptionAttribute("usermanager")]
		USERMANAGER = 37,
		[DescriptionAttribute("manager")]
		MANAGER = 38,
		[DescriptionAttribute("bulkApproves")]
		BULKAPPROVES = 39,
		[DescriptionAttribute("reviewregulatorycompliance")]
		REVIEWREGULATORYCOMPLIANCE = 40,
		[DescriptionAttribute("customregulationtask")]
		CUSTOMREGULATIONTASK = 41,
		[DescriptionAttribute("createregulationdocument")]
		CREATEREGULATIONDOCUMENT = 42,
		[DescriptionAttribute("correctiveaction")]
		CORRECTIVEACTION = 43
	}

	[TypeScriptModule("Constants")]
	public enum enActionType {
		[DescriptionAttribute("None")]
		NONE = 0,
		[DescriptionAttribute("Writer Done")]
		WRITERDONE = 1,
		[DescriptionAttribute("Reviewer Accept")]
		REVIEWERACCEPT = 2,
		[DescriptionAttribute("Reviewer Decline")]
		REVIEWERDECLINE = 3,
		[DescriptionAttribute("Reviewer Revise")]
		REVIEWERREVISE = 4,
		[DescriptionAttribute("Approver Accept")]
		APPROVERACCEPT = 5,
		[DescriptionAttribute("Approver Decline")]
		APPROVERDECLINE = 6,
		[DescriptionAttribute("Approver Revise")]
		APPROVERREVISE = 7,
		[DescriptionAttribute("Reader Done")]
		READERDONE = 8,
		[DescriptionAttribute("Read Cancel")]
		READCANCEL = 9,
		[DescriptionAttribute("Link Reviewed")]
		LINKREVIEWED = 10,
		[DescriptionAttribute("Expire Reviewed")]
		EXPIREREVIEWED = 11,
		[DescriptionAttribute("Owner Reassigned")]
		OWNERREASSIGNED = 12,
		[DescriptionAttribute("Edit In Current State")]
		EDITINCURRENTSTATE = 13,
		[DescriptionAttribute("Make Comment")]
		MAKECOMMENT = 14,
		[DescriptionAttribute("Doc Owner Done")]
		DOCOWNERDONE = 15,
		[DescriptionAttribute("Document Updated")]
		DOCUMENTUPDATED = 16,
		[DescriptionAttribute("Custom Quiz Task Done")]
		CUSTOMQUIZTASKDONE = 17,
		[DescriptionAttribute("Regulatory Compliance Set")]
		REGULATORYCOMPLIANCESET = 18,
		[DescriptionAttribute("Custom Regulation Task Complete")]
		CUSTOMREGULATIONTASKCOMPLETE = 19,
		[DescriptionAttribute("Regulation Document Created")]
		REGULATIONDOCUMENTCREATED = 20,
		[DescriptionAttribute("Corrective Action Complete")]
		CORRECTIVEACTIONDONE = 21

	}

	[TypeScriptModule("Constants")]
	public enum enLoginTypes {
		BASIC,
		AD,
		SSO,
		CONFIG,
		PUBLIC,
		ANONYMOUS,
		CHANGEPASSWORD,
		SYSTEMRECOVERY,
		SAML20,
		PTADMINCONFIG
	}

	[TypeScriptModule("Constants")]
	public enum enDocRetrievalTypes {
		UPDATEWORDDOCS = 1
	}

	[TypeScriptModule("Constants")]
	public enum enGroupTypes {
		none = 0,
		department = 1,
		jobTitle = 2,
		site = 3,
		category = 5,
		categoryValue = 6,
		departmentGroup = 7,
		globalDepartment = 10,
		documentGroup = 14,
		userNonGroup = 15,
		library = 18,
		departmentJobTitle = 19,
		jobTitleGroup = 20,
		globalJobTitleGroup = 21,
		account = 22,
		workflowStep = 23,
		globalWorkflowStep = 24,
		masterDocument = 25,
		categoryVersionNonGroup = 26
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enGroupBehaviorTypes {
		none = 1,
		regulationReview = 2,
		regulationNoReview = 4,
		regulationReviewOwnerDefault = 8,
		regulationNoReviewOwnerDefault = 16
	}

	[TypeScriptModule("Constants")]
	public enum enUserSearchTypes {
		none,
		name,
		site,
		proxyauthor,
		departmentgroups,
		jobtitlegroups,
		tasks,
		workflowStep,
		reader,
		account,
		usermanager
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentSearchTypes {
		none,
		name,
		Draft,
		inReview,
		inApproval,
		Pending,
		Approved,
		Archived,
		site,
	}

	[TypeScriptModule("Constants")]
	public enum enUserGroupTypes {
		[DescriptionAttribute("homejobtitle")]
		homejobtitle,
		[DescriptionAttribute("homedept")]
		homedept,
		[DescriptionAttribute("in")]
		IN
	}

	[TypeScriptModule("Constants")]
	public enum enLoginFailTypes {
		none = 0,
		alreadyLoggedIn = 1,
		licenseInUse = 2,
		lockedOut = 3,
		invalidLogin = 4,
		invalidTimeSpan = 5,
		invalidIP = 6
	}

	[TypeScriptModule("Constants")]
	public enum enPasswordSetFailure {
		none = 0,
		history = 1,
		complexity = 2,
	}

	[TypeScriptModule("Constants")]
	public enum enPermissionSpecificAreas {
		UserReports,
		DocumentReports,
		UserManager,
		DocumentWizard,
		Templates,
		DCAAndHROnly,
		DCAAndDocOwnerAndProxyOnly,
		DCAAndDocOwnerOnly,
		GroupManager,
		AccountManager,
		DCAAndReportManagerOnly,
		Categories,
		None,
		UserPermissionsReport
	}

	[TypeScriptModule("Constants")]
	public enum enGroupDisplayTypes {
		view,
		edit,
		home
	}

	[TypeScriptModule("Constants")]
	public enum enDBSettingNames {
		[DescriptionAttribute("Business Title")]
		BUS_TITLE,
		[DescriptionAttribute("Show All Items in Arrangement List")]
		ARRLIST_SHOW_ALL_ITEMS,
		[DescriptionAttribute("Show Document Count in Arrangement List")]
		ARRLIST_SHOW_DOCUMENT_COUNT,
		[DescriptionAttribute("Default Review Interval")]
		DEF_REV_INT,
		[DescriptionAttribute("Warn X Months before Due for Review")]
		WARN_BEFORE_REVIEW,
		[DescriptionAttribute("Public Access to Reader Comments")]
		PUBLIC_DOC_COMMENTS,
		[DescriptionAttribute("Use Water Mark")]
		USE_WATER_MARK,
		[DescriptionAttribute("Water Mark Color")]
		WATER_MARK_COLOR,
		[DescriptionAttribute("Use Auto Reference Numbering")]
		AUTO_REF_NUM,
		[DescriptionAttribute("Auto Reference Numbering Start")]
		AUTO_REF_START,
		[DescriptionAttribute("Auto Reference Numbering Offset")]
		AUTO_REF_OFFSET,
		[DescriptionAttribute("Use Files For Data")]
		USE_FILES_FOR_DATA,
		[DescriptionAttribute("Data Files Path")]
		DATA_FILES_PATH,
		[DescriptionAttribute("Database Version")]
		DB_VERSION,
		[DescriptionAttribute("Global Lockout")]
		GLOBAL_LOCKOUT,
		[DescriptionAttribute("Database GUID")]
		DBGUID,
		[DescriptionAttribute("Authentication Type")]
		AUTH_TYPE,
		[DescriptionAttribute("Use Electronic Signature")]
		USE_ELECTRONIC_SIGNATURES,
		[DescriptionAttribute("Workflow Schema Version")]
		WORKFLOW_SCHEMA_VERSION,
		[DescriptionAttribute("Reference Number Display")]
		REFERENCE_NUMBER_DISPLAY,
		[DescriptionAttribute("Download Original")]
		DOWNLOAD_ORIGINAL,
		[DescriptionAttribute("Drag Out")]
		DRAG_OUT,
		[DescriptionAttribute("Minimum Version of WordModule Forced to Users")]
		WM_FORCED_VERSION,
		[DescriptionAttribute("Send Notification to Approvers")]
		SEND_NOTIFICATION_TO_APPROVERS,
		[DescriptionAttribute("Filter users doc list by their departments")]
		FILTER_DOCUMENTS_BY_DEPARTMENTS,
		[DescriptionAttribute("Security Hash Date")]
		SECURITY_HASH_DATE,
		[DescriptionAttribute("Login Logo Justification")]
		LOGIN_LOGO_JUSTIFICATION,
		[DescriptionAttribute("Disable No Revision Necessary")]
		DISABLE_NO_REVISION_NECESSARY,
		[DescriptionAttribute("Filter doc list by language")]
		FILTER_DOCUMENTS_BY_LANGUAGE,
		[DescriptionAttribute("Prompt users to install the mobile app")]
		PROMPT_INSTALL_MOBILE_APP,
		[DescriptionAttribute("Replace Contents")]
		REPLACE_CONTENTS,
		[DescriptionAttribute("Proxy Mark as Read")]
		PROXY_MARK_AS_READ,
		[DescriptionAttribute("Regulation Display Version")]
		REGULATION_DISPLAY_VERSION,
		[DescriptionAttribute("Regulation Display Status")]
		REGULATION_DISPLAY_STATUS,
		[DescriptionAttribute("Display SubCategory Path Before Name")]
		DISPLAY_SUBCATEGORY_PATH_BEFORE_NAME,
		[DescriptionAttribute("Enable PolicyTech Embedding")]
		ENABLE_PT_EMBEDDING,
		[DescriptionAttribute("Restrict Document Viewing to Users Sites")]
		RESTRICT_DOCUMENT_VIEWING_TO_USERS_SITES,
		[DescriptionAttribute("Auto Load Grid on Browse Screen")]
		AUTO_LOAD_GRID_ON_BROWSE_SCREEN,
		[DescriptionAttribute("Show Notification Messages To Site DCAs")]
		SHOW_NOTIFICATION_MESSAGES_TO_SITE_DCAS,
		[DescriptionAttribute("Show Notification Messages To IT")]
		SHOW_NOTIFICATION_MESSAGES_TO_IT,
		[DescriptionAttribute("Allowed Upload Extensions")]
		ALLOWED_UPLOAD_EXTENSIONS,
		[DescriptionAttribute("DateLanguageModified")]
		DATE_LANGUAGE_MODIFIED,
		[DescriptionAttribute("GlobalDashboardEnabled")]
		GLOBAL_DASHBOARD_ENABLED,
		[DescriptionAttribute("UserDashboardVisibility")]
		USER_DASHBOARD_VISIBILITY,
		[DescriptionAttribute("AllowSiteDCAToCustomizeDashboard")]
		ALLOW_SITE_DCA_TO_CUSTOMIZE_DASHBOARD,
		[DescriptionAttribute("Disable Optional Mark As Read")]
		DISABLE_OPTIONAL_MARK_AS_READ
	}

	[TypeScriptModule("Constants")]
	public enum enEmailSettingNames {
		[DescriptionAttribute("Install service")]
		INSTALL_SERVICE,
		[DescriptionAttribute("Send mail interval")]
		MAIL_SEND_INTERVAL,
		[DescriptionAttribute("Send reminder interval")]
		REMIND_INTERVAL,
		[DescriptionAttribute("Server requires auth")]
		SERVER_AUTH,
		[DescriptionAttribute("SMTP server")]
		SMTP_SERVER,
		[DescriptionAttribute("SMTP port")]
		SMTP_PORT,
		[DescriptionAttribute("SMTP Domain")]
		SMTP_DOMAIN,
		[DescriptionAttribute("SMTP server account")]
		SMTP_AUTH_ACCT,
		[DescriptionAttribute("SMTP server password")]
		SMTP_AUTH_PASS,
		[DescriptionAttribute("Sender email")]
		SENDER_EMAIL,
		[DescriptionAttribute("Link URL")]
		LINK_URL,
		[DescriptionAttribute("Pending Notices Sent")]
		DATETIME_NOT_PENDING_NOTICES_SENT,
		[DescriptionAttribute("Expiration Notices Sent")]
		DATETIME_EXPIRATION_NOTICES_SENT,
		[DescriptionAttribute("SMTP Workstation")]
		SMTP_WORKSTATION,
		[DescriptionAttribute("Email Queue Load")]
		DBSETTING_EMAILQUEUE_LOAD,
		[DescriptionAttribute("USE BCC in Queue")]
		DBSETTING_EMAILQUEUE_USE_BCC,
		[DescriptionAttribute("Users per BCC email")]
		DBSETTING_EMAILQUEUE_USERS_PER_EMAIL,
		[DescriptionAttribute("Bulk Email Address")]
		DBSETTING_EMAILQUEUE_BCC_ADDRESS,
		[DescriptionAttribute("Max Threads")]
		DBSETTING_EMAILQUEUE_MAX_THREADS,
		[DescriptionAttribute("Bulk Email Name")]
		DBSETTING_EMAILQUEUE_BCC_NAME,
		[DescriptionAttribute("Use Bulk Mail")]
		DBSETTING_EMAILQUEUE_USE_BULK,
		[DescriptionAttribute("Process but do not email")]
		DBSETTING_PROCESS_BUT_DO_NOT_SEND,
		[DescriptionAttribute("Task Summary Use Reminder Interval")]
		TASK_SUMMARY_USE_REMINDER_INTERVAL,
		[DescriptionAttribute("Task Summary Reminder Interval")]
		TASK_SUMMARY_REMINDER_INTERVAL,
		[DescriptionAttribute("Task Summary Reminder Interval Contacts")]
		TASK_SUMMARY_REMINDER_INTERVAL_CONTACTS,
		[DescriptionAttribute("Task Summary Use Send On")]
		TASK_SUMMARY_USE_SEND_ON,
		[DescriptionAttribute("Task Summary Use Send On Contacts")]
		TASK_SUMMARY_USE_SEND_ON_CONTACTS,
		[DescriptionAttribute("Task Summary Send On Days")]
		TASK_SUMMARY_SEND_ON_DAYS,
		[DescriptionAttribute("Task Summary Send On Days Contacts")]
		TASK_SUMMARY_SEND_ON_DAYS_CONTACTS,
		[DescriptionAttribute("Task Summary Frequency")]
		TASK_SUMMARY_FREQUENCY,
		[DescriptionAttribute("Task Summary Frequency Contacts")]
		TASK_SUMMARY_FREQUENCY_CONTACTS,
		[DescriptionAttribute("Task Summary Reminder Start Time")]
		TASK_SUMMARY_REMIND_START_TIME,
		[DescriptionAttribute("Task Summary Reminder Start Time Contacts")]
		TASK_SUMMARY_REMIND_START_TIME_CONTACTS,
		[DescriptionAttribute("Overdue Tasks Use Reminder Interval")]
		OVERDUE_TASKS_USE_REMINDER_INTERVAL,
		[DescriptionAttribute("Overdue Tasks Send On Days")]
		OVERDUE_TASKS_SEND_ON_DAYS,
		[DescriptionAttribute("Overdue Tasks Reminder Start Time")]
		OVERDUE_TASKS_REMIND_START_TIME,
		[DescriptionAttribute("Use SSL")]
		DBSETTING_USE_SSL,
		[DescriptionAttribute("Send Task Alerts From")]
		DBSETTING_SEND_TASK_ALERTS_FROM,
		[DescriptionAttribute("Individual Task Summary Only Period")]
		DBSETTING_SEND_TASK_SUMMARY_ONLY_PERIOD,
		[DescriptionAttribute("Use Custom Schedule Email Settings")]
		USE_CUSTOM_SCHEDULE_EMAIL_SETTINGS,
		[DescriptionAttribute("Last Task Summary Sent")]
		LAST_TASK_SUMMARY_SENT,
		[DescriptionAttribute("Last Task Summary Sent Contacts")]
		LAST_TASK_SUMMARY_SENT_CONTACTS,
		[DescriptionAttribute("Last OverDue Notification Sent")]
		LAST_OVERDUE_NOTIFICATION_SENT,
		[DescriptionAttribute("Error Report Email Address")]
		ERROR_REPORT_EMAIL_ADDRESS,
		[DescriptionAttribute("Use Custom Error Report Settings")]
		USE_CUSTOM_ERROR_REPORT_SETTINGS,
		[DescriptionAttribute("Use Custom Schedule Email Settings Contacts")]
		USE_CUSTOM_SCHEDULE_EMAIL_SETTINGS_CONTACTS,
		[DescriptionAttribute("Date Notified Of Failed Cases")]
		ENABLE_NEW_EMPLOYEE_WELCOME_EMAIL,
		[DescriptionAttribute("Date Notified Of New Employee Welcome")]
		DATE_NOTIFIED_NEW_EMPLOYEE_WELCOME,
		[DescriptionAttribute("Date Notified Of Failed Logins")]
		DATE_NOTIFIED_OF_FAILED_LOGINS,
		[DescriptionAttribute("Last Check Sys Notification by Master Sched")]
		LAST_CHECK_SYSTEM_NOTIFICATION_BY_MASTER_SCHEDULER,
		[DescriptionAttribute("Selected Method for Sending Emails")]
		SEND_EMAILS_SELECTED_SEND_METHOD,
		[DescriptionAttribute("Suppress Initial Reader Task Emails")]
		DBSETTING_SUPPRESS_INITIAL_READER_TASK_EMAILS,
		[DescriptionAttribute("Suppress Initial Overdue Reader Task Emails")]
		DBSETTING_SUPPRESS_INITIAL_OVERDUE_READER_TASK_EMAILS,
		[DescriptionAttribute("Escalation Summary Emails Enabled")]
		DBSETTING_ESCALATION_SUMMARY_EMAILS_ENABLED
	}

	[TypeScriptModule("Constants")]
	public enum enEmailSendFrequency {
		[DescriptionAttribute("once a month")]
		ONCE_A_MONTH,
		[DescriptionAttribute("every other week")]
		EVERY_OTHER_WEEK,
		[DescriptionAttribute("selectedDays")]
		SELECTED_DAYS
	}

	[TypeScriptModule("Constants")]
	public enum enEmailSendTaskAlertsFrom {
		[DescriptionAttribute("system")]
		SYSTEM,
		[DescriptionAttribute("docOwner")]
		DOCOWNER,
	}

	[TypeScriptModule("Constants")]
	public enum enLoginSettingNames {
		[DescriptionAttribute("Login Timeout")]
		TIMEOUT,
		[DescriptionAttribute("Login Option")]
		LOGIN_OPTION,
		[DescriptionAttribute("Login Screen Message")]
		LOGIN_MSG,
		[DescriptionAttribute("Num of Login Attempts")]
		LOGIN_ATTEMPTS,
		[DescriptionAttribute("Time Between Login Re-Attempts")]
		ATTEMPTS_INTERVAL,
		[DescriptionAttribute("Lockout Timeout")]
		LOCKOUT_TIMEOUT,
		[DescriptionAttribute("Log Login Attempts")]
		LOG_LOGINS,
		[DescriptionAttribute("Log Logoffs")]
		LOG_LOGOUTS,
		[DescriptionAttribute("IP Address Range Private")]
		IP_ALLOWED_PRIVATE_RANGES,
		[DescriptionAttribute("IP Address Range Public")]
		IP_ALLOWED_PUBLIC_RANGES,
		[DescriptionAttribute("FIPS Conversion")]
		FIPS_CONVERSION,
		[DescriptionAttribute("SAML X509 Certificate")]
		SAML_X509Cert,
		[DescriptionAttribute("SAML Issuer")]
		SAML_Issuer,
		[DescriptionAttribute("SAML Allowable Clock Skew")]
		SAML_CLOCKSKEW,
		[DescriptionAttribute("SAML Deep Linking")]
		SAML_DEEPLINKING,
		[DescriptionAttribute("SAML SignOn URL")]
		SAML_SIGNONURL,
		[DescriptionAttribute("Log Out URL")]
		LOGOUTURL,
		[DescriptionAttribute("SAML Service Provider ID")]
		SAML_SERVICEPROVIDERID,
		[DescriptionAttribute("SAML RelayState Variable")]
		SAML_RELAYSTATEVARIABLE,
		[DescriptionAttribute("User Store Default Site")]
		USER_STORE_DEFAULT_SITE,
		[DescriptionAttribute("Enable Keep Me Logged In")]
		ENABLE_KEEP_ME_LOGGED_IN
	}

	[TypeScriptModule("Constants")]
	public enum enPasswordSettingNames {
		[DescriptionAttribute("Required Password Length")]
		PASSWORD_LENGTH,
		[DescriptionAttribute("Allow User Non-Required Password Changes")]
		USER_PWD_CHANGE,
		[DescriptionAttribute("Change Password Interval")]
		CHANGE_PASSWORD_INT,
		[DescriptionAttribute("Change Password on First Login")]
		CHG_PASSWORD_FIRST_LOGIN,
		[DescriptionAttribute("Password History")]
		PASSWORD_HISTORY,
		[DescriptionAttribute("Uppercase Character Count")]
		PASSWORD_UCASE,
		[DescriptionAttribute("Special Character Count")]
		PASSWORD_SPECIAL,
		[DescriptionAttribute("Numeric Character Count")]
		PASSWORD_NUMERIC
	}

	[TypeScriptModule("Constants")]
	public enum enADSettingNames {
		[DescriptionAttribute("Active Directory Domain")]
		AD_DOMAIN,
		[DescriptionAttribute("Active Directory User")]
		AD_USER,
		[DescriptionAttribute("Active Directory Password")]
		AD_PASSWORD,
		[DescriptionAttribute("Active Directory Site")]
		AD_SITE,
		[DescriptionAttribute("Active Directory Alt Filter")]
		AD_ALT_METHOD,
		[DescriptionAttribute("Active Directory Base DN")]
		AD_BASEDN,
		[DescriptionAttribute("Active Directory Filter")]
		AD_FILTER,
		[DescriptionAttribute("Active Directory Synch")]
		AD_SYNCH,
		[DescriptionAttribute("Active Directory Last AD Synch Date")]
		AD_LASTSYNCHDATE,
		[DescriptionAttribute("Active Directory Synch Time")]
		AD_SYNCHTIME,
		[DescriptionAttribute("Active Directory Restore Deleted")]
		AD_RESTOREDELETED,
		[DescriptionAttribute("Active Directory Root")]
		AD_ROOT,
		[DescriptionAttribute("Active Directory Email Failure")]
		AD_EMAILFAIL,  //email address where synch failures are sent	
		[DescriptionAttribute("Active Directory Sync Queue Length")]
		AD_SYNCQUEUELENGTH,
		[DescriptionAttribute("LoginURL")]
		AD_LOGIN_URL,
		[DescriptionAttribute("URLToProgram")]
		AD_URLTOPROGRAM,
		[DescriptionAttribute("Active Directory Delete Inactive")]
		AD_DELETEINACTIVE
	}

	[TypeScriptModule("Constants")]
	public enum enIssueManagerSettings {
		[DescriptionAttribute("Report Issue URL")]
		INTEGRATION_REPORT_ISSUE_URL,
		[DescriptionAttribute("Web Service URL")]
		INTEGRATION_WEBSERVICE_URL,
		[DescriptionAttribute("Web Service Username")]
		INTEGRATION_WEBSERVICE_USERNAME,
		[DescriptionAttribute("Web Service Password")]
		INTEGRATION_WEBSERVICE_PASSWORD,
		[DescriptionAttribute("Web Service ClientID")]
		INTEGRATION_WEBSERVICE_CLIENT_ID,
		[DescriptionAttribute("Sync to Category")]
		INTEGRATION_SYNC_TO_CATEGORY,
		[DescriptionAttribute("Issue Sync Activated")]
		INTEGRATION_SYNC_ACTIVATED,
		[DescriptionAttribute("Issue Sync Time")]
		INTEGRATION_SYNC_TIME,
		[DescriptionAttribute("Last Issue Sync Time")]
		INTEGRATION_LAST_SYNC_TIME,
		[DescriptionAttribute("Case Creation Activated")]
		INTEGRATION_CASE_CREATION_ACTIVATED,
		[DescriptionAttribute("Case Tier")]
		INTEGRATION_CASE_TIER,
		[DescriptionAttribute("Case Issue Type")]
		INTEGRATION_CASE_ISSUE_TYPE,
		[DescriptionAttribute("Case Source")]
		INTEGRATION_CASE_SOURCE,
		[DescriptionAttribute("Case Status")]
		INTEGRATION_CASE_STATUS,
		[DescriptionAttribute("Case Type")]
		INTEGRATION_CASE_TYPE
	}

	[TypeScriptModule("Constants")]
	public enum enSelectionType {
		[DescriptionAttribute("single,input")]
		SINGLE_SELECT_ALLOW_INPUT,
		[DescriptionAttribute("single")]
		SINGLE_SELECT_NO_INPUT,
		[DescriptionAttribute("mult,input")]
		MULTI_SELECT_ALLOW_INPUT,
		[DescriptionAttribute("mult")]
		MULTI_SELECT_NO_INPUT
	}

	[TypeScriptModule("Constants")]
	public enum enSSOSettingNames {
		[DescriptionAttribute("Encryption Type")]
		SSO_ENCRYPTION_TYPE,
		[DescriptionAttribute("Private Key")]
		SSO_PRIVATE_KEY,
		[DescriptionAttribute("Login URL")]
		SSO_LOGIN_URL,
		[DescriptionAttribute("CookieName")]
		SSO_COOKIE_NAME
	}

	[TypeScriptModule("Constants")]
	public enum enUserImportSettingNames {
		[DescriptionAttribute("User Import CSV/TAB Mapping")]
		USERIMPORT_MAP,
		[DescriptionAttribute("Contact Import CSV/TAB Mapping")]
		CONTACTIMPORT_MAP,
		[DescriptionAttribute("Auto User Import CSV/TAB Mapping")]
		USERIMPORT_MAP_AUTO,
		[DescriptionAttribute("User Import Domain")]
		USERIMPORT_DOMAIN,
		[DescriptionAttribute("User Import Username")]
		USERIMPORT_USERNAME,
		[DescriptionAttribute("User Import Password")]
		USERIMPORT_PASSWORD,
		[DescriptionAttribute("User Import File Path")]
		USERIMPORT_FILEPATH,
		[DescriptionAttribute("User Import Notify Email")]
		USERIMPORT_NOTIFY_EMAIL,
		[DescriptionAttribute("User Import Activated")]
		USERIMPORT_ACTIVATED,
		[DescriptionAttribute("User Import Sync Time")]
		USERIMPORT_SYNCH_TIME,
		[DescriptionAttribute("User Import Report Purge Int")]
		USERIMPORT_PURGE_INTERVAL,
		[DescriptionAttribute("User Import File Encoding")]
		USERIMPORT_FILE_ENCODING,
		[DescriptionAttribute("User Import Last Sync Time")]
		USERIMPORT_LAST_SYNCH_TIME,
		[DescriptionAttribute("User Import User Domain")]
		USERIMPORT_DOMAIN_ADD,
		[DescriptionAttribute("User Import Skip First Line")]
		USERIMPORT_SKIPFIRSTLN,
		[DescriptionAttribute("User Import Delete Users")]
		USERIMPORT_DELETEUSERS,
		[DescriptionAttribute("User Import Overwrite Username")]
		USERIMPORT_OVERWRITEUNAME,
		[DescriptionAttribute("User Import Overwrite Password")]
		USERIMPORT_OVERWRITEPWD,
		[DescriptionAttribute("User Import Monitor File for Changes")]
		USERIMPORT_MONITORFILEFORCHANGES,
		[DescriptionAttribute("Client API Key")]
		USERIMPORT_CLIENTAPIKEY,
		[DescriptionAttribute("User Import Report Only Displays Changes")]
		USERIMPORT_REPORT_ONLY_DISPLAYS_CHANGES,
		[DescriptionAttribute("User Import Overwrite Manager")]
		USERIMPORT_OVERWRITEMANAGER,
		[DescriptionAttribute("User Import Queue Length")]
		USERIMPORT_QUEUELENGTH,
		[DescriptionAttribute("User Import Ignore Blank Values")]
		USERIMPORT_IGNOREBLANKVALUES
	}

	[TypeScriptModule("Constants")]
	public enum enDepartmentImportSettingNames {
		[DescriptionAttribute("Department Import File Path")]
		DEPARTMENTIMPORT_FILEPATH,
		[DescriptionAttribute("Department Import Last Sync Time")]
		DEPARTMENTIMPORT_LAST_SYNC_TIME
	}

	[TypeScriptModule("Constants")]
	public enum enLogActions {
		[DescriptionAttribute("rename")]
		RENAME,
		[DescriptionAttribute("delete")]
		DELETE,
		[DescriptionAttribute("add")]
		ADD,
		[DescriptionAttribute("assign")]
		ASSIGN,
		[DescriptionAttribute("unassign")]
		UNASSIGN,
		[DescriptionAttribute("mergerightintoleft")]
		MERGERIGHTINTOLEFT,
		[DescriptionAttribute("statuschange")]
		STATUS_CHANGE,
		[DescriptionAttribute("docpropertychange")]
		DOC_PROPERTY_CHANGE,
		[DescriptionAttribute("userpropertychange")]
		USER_PROPERTY_CHANGE,
		[DescriptionAttribute("grouppropertychange")]
		GROUP_PROPERTY_CHANGE,
		[DescriptionAttribute("settingchange")]
		SETTING_CHANGE,
		[DescriptionAttribute("usersettingchange")]
		USER_SETTING_CHANGE,
		[DescriptionAttribute("restore")]
		RESTORE,
		[DescriptionAttribute("archive")]
		ARCHIVE,
		[DescriptionAttribute("resetexpire")]
		RESET_EXPIRE,
		[DescriptionAttribute("replacerightwithleft")]
		REPLACERIGHTWITHLEFT,
		[DescriptionAttribute("editdocument")]
		EDITDOCUMENT,
		[DescriptionAttribute("RunQuery")]
		RUNQUERY,
		[DescriptionAttribute("updatexdepartmentid")]
		UPDATEXDEPARTMENTID,
		[DescriptionAttribute("updatexjobtitleid")]
		UPDATEXJOBTITLEID,
		[DescriptionAttribute("changegrouptype")]
		CHANGEGROUPTYPE,
		[DescriptionAttribute("groupsettingchange")]
		GROUP_SETTING_CHANGE,
		[DescriptionAttribute("useraction")]
		USER_ACTION,
		[DescriptionAttribute("languagesettingchange")]
		LANGUAGE_SETTING_CHANGE,
		[DescriptionAttribute("categoryversionpropertychange")]
		CATEGORYVERSION_PROPERTY_CHANGE,
		[DescriptionAttribute("configlogin")]
		CONFIG_LOGIN,
		[DescriptionAttribute("customattributechange")]
		CUSTOM_ATTRIBUTE_CHANGE,
		[DescriptionAttribute("usercustomattributevalues")]
		USER_CUSTOM_ATTRIBUTE_VALUES,
		[DescriptionAttribute("GroupRuleValues")]
		GROUP_RULE_VALUES,
		[DescriptionAttribute("NightlyBackupDownloaded")]
		NIGHTLY_BACKUP_DOWNLOADED
	}

	[TypeScriptModule("Constants")]
	public enum enLogRelationships {
		[DescriptionAttribute("group")]
		GROUP,
		[DescriptionAttribute("doc")]
		DOC,
		[DescriptionAttribute("user")]
		USER,
		[DescriptionAttribute("parentdocchilddoc")]
		PARENTDOCCHILDDOC,
		[DescriptionAttribute("docuser")]
		DOCUSER,
		[DescriptionAttribute("usergroup")]
		USERGROUP,
		[DescriptionAttribute("docgroup")]
		DOCGROUP,
		[DescriptionAttribute("parentgrpchildgrp")]
		PARENTGRPCHILDGRP,
		[DescriptionAttribute("parentuserchilduser")]
		PARENTUSERCHILDUSER,
		[DescriptionAttribute("businesstitle")]
		BUSTITLE,
		[DescriptionAttribute("userpermission")]
		USERPERMISSION,
		[DescriptionAttribute("title")]
		TITLE,
		[DescriptionAttribute("owner")]
		OWNER,
		[DescriptionAttribute("proxyauthor")]
		PROXY_AUTHOR,
		[DescriptionAttribute("templateid")]
		TEMPLATEID,
		[DescriptionAttribute("version")]
		VERSION,
		[DescriptionAttribute("referencenumber")]
		REFERENCE_NUMBER,
		[DescriptionAttribute("reviewinterval")]
		REVIEW_INTERVAL,
		[DescriptionAttribute("warningperiod")]
		WARNING_PERIOD,
		[DescriptionAttribute("useinitialreviewdate")]
		USE_INITIAL_REVIEW_DATE,
		[DescriptionAttribute("initialreviewdate")]
		INITIAL_REVIEW_DATE,
		[DescriptionAttribute("useofficemodule")]
		USE_OFFICE_MODULE,
		[DescriptionAttribute("publicationdate")]
		PUBLICATION_DATE,
		[DescriptionAttribute("useuserspecifiedpublicationdate")]
		USE_USER_SPECIFIED_PUBLICATION_DATE,
		[DescriptionAttribute("requirereadinpending")]
		REQUIRE_READ_IN_PRENDING,
		[DescriptionAttribute("originalcreationdate")]
		ORIGINAL_CREATION_DATE,
		[DescriptionAttribute("emailnotifylevel")]
		EMAIL_NOTIFY_LEVEL,
		[DescriptionAttribute("allownotifyleveltobemodified")]
		ALLOW_NOTIFY_LEVEL_TO_BE_MODIFIED,
		[DescriptionAttribute("readinterval")]
		READ_INTERVAL,
		[DescriptionAttribute("securitylevel")]
		SECURITY_LEVEL,
		[DescriptionAttribute("documenttype")]
		DOCUMENT_TYPE,
		[DescriptionAttribute("workflowid")]
		WORKFLOWID,
		[DescriptionAttribute("autoaddnewcats")]
		AUTO_ADD_NEW_CATS,
		[DescriptionAttribute("autoaddnewsites")]
		AUTO_ADD_NEW_SITES,
		[DescriptionAttribute("templateavailability")]
		TEMPLATE_AVAILABILITY,
		[DescriptionAttribute("email")]
		EMAIL,
		[DescriptionAttribute("customuniqueid")]
		CUSTOM_UNIQUE_ID,
		[DescriptionAttribute("addomainid")]
		ADDOMAIN_ID,
		[DescriptionAttribute("lockout")]
		LOCK_OUT,
		[DescriptionAttribute("referenceid")]
		REFERENCE_ID,
		[DescriptionAttribute("workflowid")]
		WORKFLOW_ID,
		[DescriptionAttribute("autoadd")]
		AUTO_ADD,
		[DescriptionAttribute("comments")]
		COMMENTS,
		[DescriptionAttribute("selectiontype")]
		SELECTION_TYPE,
		[DescriptionAttribute("defaultview")]
		DEFAULT_VIEW,
		[DescriptionAttribute("defaultsort")]
		DEFAULT_SORT,
		[DescriptionAttribute("timezone")]
		TIME_ZONE,
		[DescriptionAttribute("languagecode")]
		LANGUAGE_CODE,
		[DescriptionAttribute("dateformat")]
		DATE_FORMAT,
		[DescriptionAttribute("timeformat")]
		TIME_FORMAT,
		[DescriptionAttribute("anonymousaccess")]
		ANONYMOUS_ACCESS,
		[DescriptionAttribute("iprange")]
		IP_RANGE,
		[DescriptionAttribute("markasreadtext")]
		MARK_AS_READ_TEXT,
		[DescriptionAttribute("defaulttab")]
		DEFAULT_TAB,
		[DescriptionAttribute("allownotifyleveltobedisplayed")]
		ALLOW_NOTIFY_LEVEL_TO_BE_DISPLAYED,
		[DescriptionAttribute("alloweditingdocmodetobemodified")]
		ALLOW_EDIT_DOC_MODE_TO_BE_MODIFIED,
		[DescriptionAttribute("alloweditingdocmodetobedisplayed")]
		ALLOW_EDIT_DOC_MODE_TO_BE_DISPLAYED,
		[DescriptionAttribute("allowguests")]
		ALLOW_GUESTS,
		[DescriptionAttribute("flaggedforreview")]
		FLAGGED_FOR_REVIEW,
		[DescriptionAttribute("retaindraftsnapshots")]
		RETAIN_DRAFT_SNAPSHOTS,
		[DescriptionAttribute("forceexpire")]
		FORCE_EXPIRE,
		[DescriptionAttribute("allowlocalizationworkflow")]
		ALLOW_LOCALIZATION_WORKFLOW,
		[DescriptionAttribute("instructions")]
		INSTRUCTIONS,
		[DescriptionAttribute("createinitialownertasks")]
		CREATE_INITIAL_OWNER_TASKS,
		[DescriptionAttribute("docrelationtype")]
		DOC_RELATION_TYPE,
		[DescriptionAttribute("usertype")]
		USER_TYPE,
		[DescriptionAttribute("contactjobtitle")]
		CONTACT_JOBTITLE,
		[DescriptionAttribute("userstore")]
		USER_STORE,
		[DescriptionAttribute("userstoreuserid")]
		USER_STORE_USERID,
		[DescriptionAttribute("contactdepartment")]
		CONTACT_DEPARTMENT,
		[DescriptionAttribute("address")]
		ADDRESS,
		[DescriptionAttribute("city")]
		CITY,
		[DescriptionAttribute("state")]
		STATE,
		[DescriptionAttribute("postalcode")]
		POSTAL_CODE,
		[DescriptionAttribute("country")]
		COUNTRY,
		[DescriptionAttribute("defaultsearchin")]
		DEFAULT_SEARCH_IN,
		[DescriptionAttribute("defaultsearchby")]
		DEFAULT_SEARCH_BY,
		[DescriptionAttribute("secondname")]
		SECOND_NAME,
		[DescriptionAttribute("phonenumber")]
		PHONE_NUMBER,
		[DescriptionAttribute("website")]
		WEBSITE,
		[DescriptionAttribute("acronym")]
		ACRONYM,
		[DescriptionAttribute("dontallowdocassign")]
		DONT_ALLOW_DOC_ASSIGN,
		[DescriptionAttribute("userspecifiedpublicationdate")]
		USER_SPECIFIED_PUBLICATION_DATE,
		[DescriptionAttribute("versionchangesummary")]
		VERSION_CHANGE_SUMMARY,
		[DescriptionAttribute("useinitialreaddate")]
		USE_INITIAL_READ_DATE,
		[DescriptionAttribute("initialreaddate")]
		INITIAL_READ_DATE,
		[DescriptionAttribute("useenhancedvalidation")]
		USE_ENHANCED_VALIDATION,
		[DescriptionAttribute("allowenhancedvalidationtobedisplayed")]
		ALLOW_ENHANCED_VALIDATION_TO_BE_DISPLAYED,
		[DescriptionAttribute("allowenhancedvalidationtobemodified")]
		ALLOW_ENHANCED_VALIDATION_TO_BE_MODIFIED,
		[DescriptionAttribute("groupbehaviortype")]
		GROUP_BEHAVIOR_TYPE,
		[DescriptionAttribute("daystasksduebeforeactivation")]
		DAYS_TASKS_DUE_BEFORE_ACTIVATION,
		[DescriptionAttribute("description")]
		DESCRIPTION,
		[DescriptionAttribute("activationdate")]
		ACTIVATIONDATE,
		[DescriptionAttribute("effectivedate")]
		EFFECTIVEDATE,
		[DescriptionAttribute("doccategoryversion")]
		DOCCATEGORYVERSION,
		[DescriptionAttribute("defaultsearchview")]
		DEFAULT_SEARCH_VIEW,
		[DescriptionAttribute("password")]
		PASSWORD,
		[DescriptionAttribute("username")]
		USERNAME, 
		[DescriptionAttribute("customattribute")]
		CUSTOM_ATTRIBUTE,
		[DescriptionAttribute("name")]
		NAME,
		[DescriptionAttribute("datatype")]
		DATA_TYPE,
		[DescriptionAttribute("allowmultiples")]
		ALLOW_MULTIPLES,
		[DescriptionAttribute("groupRule")]
		GROUP_RULE,
		[DescriptionAttribute("create")]
		CREATE,
		[DescriptionAttribute("delete")]
		DELETE,
		[DescriptionAttribute("comparetype")]
		COMPARE_TYPE,
		[DescriptionAttribute("valueone")]
		VALUE_ONE,
		[DescriptionAttribute("valuetwo")]
		VALUE_TWO
	}

	[TypeScriptModule("Constants")]
	public enum enCryptographyMode {
		AD,
		SSO,
		INTERNAL,
		CLIENT,
		REGKEY
	}

	[TypeScriptModule("Constants")]
	public enum enRuleTypes {
		all,
		automatic,
		manual
	}

	[TypeScriptModule("Constants")]
	public enum PropertyTreeFilterResultType {
		none,
		department,
		category,
		categoryValue,
		documentStatus,
		dateCreated,
		dateApproved,
		dateEffective,
		dateSubmit,
		dateExpires,
		dateArchived,
		library,
		jobtitle,
		departmentjobtitle,
		templateLibrary,
		workflowStep,
		documentWorkflowStep,
		template,
		dateInEffect,
		dateSubmittedToApproval,
		site
	}

	[TypeScriptModule("Constants")]
	public enum enDateRanges {
		allDates,
		last24Hours,
		last7Days,
		last30Days,
		last60Days,
		last90Days,
		lastMonth,
		lastQuarter,
		last6Months,
		last12Months,
		lastYear,
		custom
	}

	[TypeScriptModule("Constants")]
	public enum enTempAuthTimeoutInterval {
		DAYS = 1,
		HOURS = 2,
		MINUTES = 3
	}

	[TypeScriptModule("Constants")]
	public enum enTaskDateFilter {
		None,
		StartDate,
		CompleteDate,
		EndDate
	}

	[TypeScriptModule("Constants")]
	public enum enChangeDescription {
		DocVarsChanged,
		NoRevisionNecessary,
		DocOverwrittenByUpload,
		None,
		RegulationModified,
		RegulationAdded
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentRevision {
		InitallyApproved = 0,
		RevisionInEdit = -1,
		EditInCurrentState = -2,
		GetLatestRevision = -3,
		DoesNotMatter = -4,
		ERROR_NotFound = -5,
		NewSnapshot = -6,
		EditInCurrentStateBEGIN = -7,
		ERROR_NotSet = -8,
		ArchivedDraftBegins = -20
	}


	[TypeScriptModule("Constants")]
	public enum EWDFields {
		wdFieldDocVariable = 64,
		wdFieldTime = 32,
		wdFieldPage = 33,
		wdFieldDate = 31,
		wdFieldNumPages = 26,
		wdFieldAuthor = 17,
		wdFieldDocProperty = 85,
		wdFieldTitle = 15
	}

	[TypeScriptModule("Constants")]
	internal enum EWDTypes {
		wdHeaderFooterPrimary = 1,
		wdRelativeHorizontalPositionPage = 1,
		wdRelativeVerticalPositionMargin = 0,
		wdShapeCenter = -999995,
		wdWrapNone = 3,
		wdAllowOnlyComments = 1,
		wdAllowOnlyRevisions = 0,
		wdDoNotSaveChanges = 0
	}

	[TypeScriptModule("Constants")]
	internal enum EWDStory {
		wdCommentsStory = 4,
		wdEndnotesStory = 3,
		wdEvenPagesFooterStory = 8,
		wdEvenPagesHeaderStory = 6,
		wdFirstPageFooterStory = 11,
		wdFirstPageHeaderStory = 10,
		wdFootnotesStory = 2,
		wdMainTextStory = 1,
		wdPrimaryFooterStory = 9,
		wdPrimaryHeaderStory = 7,
		wdTextFrameStory = 5,
		wdFormatText = 2
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enTaskStatus {
		[DescriptionAttribute("NotYetActive")]
		notYetActive = 1,
		[DescriptionAttribute("Active")]
		active = 2,
		[DescriptionAttribute("Complete")]
		complete = 4,
		[DescriptionAttribute("Cancelled")]
		cancelled = 8,
		[DescriptionAttribute("AllUnCancelled")]
		allUnCancelled = 16,
		[DescriptionAttribute("All")]
		all = 32,
		[DescriptionAttribute("AllUnEndDated")]
		allUnEnded = 64,
		[DescriptionAttribute("InProgress")]
		inProgressDONTUSE = 128,
		[DescriptionAttribute("AllCancelledOrComplete")]
		allCancelledOrComplete = 256
	}

	[TypeScriptModule("Constants")]
	public enum enIntermediaryActions {
		[DescriptionAttribute("None")]
		None = 0,
		[DescriptionAttribute("Make Comment")]
		MakeComment = 1,
		[DescriptionAttribute("Save")]
		Save = 2,
		[DescriptionAttribute("Save With Comments")]
		SaveWithComments = 3,
		[DescriptionAttribute("Decline")]
		Decline = 4,
		[DescriptionAttribute("Revise")]
		Revise = 5,
		[DescriptionAttribute("Notes")]
		Notes = 6,
		[DescriptionAttribute("Replace Documents")]
		ReplaceDocuments = 7,
		[DescriptionAttribute("New Version")]
		NewVersion = 8,
		[DescriptionAttribute("Mark As Read")]
		MarkAsRead = 9,
		[DescriptionAttribute("Prompt No Replace")]
		PromptNoReplace = 10,
		[DescriptionAttribute("Prompt Delete")]
		PromptDelete = 11,
		[DescriptionAttribute("Mandatory Items Selected With Comments")]
		MandatoryItemsSelected = 12,
		[DescriptionAttribute("Prompt If No Writers")]
		PromptIfNoWriters = 13,
		[DescriptionAttribute("Edit In Current State")]
		EditInCurrentState = 14,
		[DescriptionAttribute("View Document")]
		ViewDocument = 15,
		[DescriptionAttribute("Edit Document")]
		EditDocument = 16,
		[DescriptionAttribute("Edit Document Track Changes")]
		EditDocumentTrackChanges = 17,
		[DescriptionAttribute("Edit Document Track Changes Locked")]
		EditDocumentTrackChangesLocked = 18,
		Properties = 19,
		[DescriptionAttribute("Edit Quiz")]
		EditQuiz = 20,
		Overview = 21,
		[DescriptionAttribute("Prompt Archive")]
		PromptArchive = 22,
		[DescriptionAttribute("Accept With Comments")]
		AcceptWithComments = 23,
		[DescriptionAttribute("Prompt Set As Approved")]
		PromptSetAsApproved = 24,
		[DescriptionAttribute("Edit In Current State Done")]
		EditInCurrentStateDone = 25,
		[DescriptionAttribute("Modify Tasks")]
		ModifyTasks = 26,
		[DescriptionAttribute("View Quiz")]
		ViewQuiz = 27,
		[DescriptionAttribute("Restore Document")]
		RestoreDocument = 28,
		[DescriptionAttribute("Prompt If No Reviewers")]
		PromptIfNoReviewers = 29,
		[DescriptionAttribute("Prompt if no Approvers")]
		PromptIfNoApprovers = 30,
		[DescriptionAttribute("View Document: Client")]
		ViewDocumentClient = 31,
		[DescriptionAttribute("Edit Document: Client")]
		EditDocumentClient = 32,
		[DescriptionAttribute("Properties: Client")]
		PropertiesClient = 33,
		[DescriptionAttribute("Request Changes: Client")]
		RequestChangesClient = 34,
		[DescriptionAttribute("Prompt No Revision Necessary")]
		PromptNoRevisionNecessary = 35,
		[DescriptionAttribute("Request Update")]
		RequestUpdate = 36,
		[DescriptionAttribute("Report Incident")]
		ReportIncident = 37,
		[DescriptionAttribute("Request Submit for Review")]
		RequestSubmitForReview = 38,
		[DescriptionAttribute("Submit for Periodic Review")]
		SubmitForPeriodicReview = 39,
		[DescriptionAttribute("Send to Draft")]
		SendToDraft = 40,
		[DescriptionAttribute("Change Compliance")]
		ChangeCompliance = 41
	}

	[TypeScriptModule("Constants")]
	public enum enWorkflowType {
		General,
		Contracts
	}

	[TypeScriptModule("Constants")]
	public enum enWorkflowSystemDefault {
		SystemDefault
	}

	[TypeScriptModule("Constants")]
	public enum enWorkflowSysSteps {
		DefaultSteps,
		DocumentAccess,
		DocumentLocation,
		[DescriptionAttribute("ReviewLinked")]
		ReviewLinkedDocument,
		ReviewExpired,
		ReassignOwner,
		MakeComment,
		Favorite,
		TemplateUser,
		AccountRepresentative,
		NotifyDocumentAvailable,
		UpdateDocument,
		CancelRead,
		CustomQuizTask,
		ReviewRegulatoryCompliance,
		CorrectiveAction,
		CreateRegulationDocument,
		CustomRegulationTask
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enWorkflowDisplayCodes {
		[DescriptionAttribute("Don't Display in Wizard")]
		DontDisplayInWizard = 0x01,
		[DescriptionAttribute("Display in Wizard (Optional)")]
		DisplayInWizardOptional = 0x02,
		[DescriptionAttribute("Display in Wizard (Required)")]
		DisplayInWizardRequired = 0x04,
		[DescriptionAttribute("Display in Wizard (Client Required)")]
		DisplayInWizardClientRequired = 0x08,
		[DescriptionAttribute("Display in Wizard (Client Optional)")]
		DisplayInWizardClientOptional = 0x10
	}

	//This enumeration should be ordered by escalation level, as the integer values are used to determine escalation level
	[TypeScriptModule("Constants")]
	public enum enEscalationStatus {
		None = 0,
		Warning = 10,
		Due = 20,
		Critical = 30
	}

	[TypeScriptModule("Constants")]
	public enum enPermissionFilterType {
		GlobalMatch = 0,
		AnyMatch = 1,
		SpecificMatch = 2
	}

	[TypeScriptModule("Constants")]
	public enum enDueTypes {
		None = 0,
		Range = 1,
		Specific = 2
	}

	[TypeScriptModule("Constants")]
	public enum enWorkflowSysRules {
		CancelMarkAsRead,
		LinkReviewed,
		ExpireReviewed,
		SystemSnapshot,
		MakeComment,
		DocumentCreated,
		DocumentUpdated,
		CustomQuizTaskDone,
		RegulatoryComplianceSet,
		CustomTaskComplete,
		WorkflowRestartForCompliance,
		CorrectiveActionTaken,
		RegulationDocumentCreated,
		CustomRegulationTaskComplete
	}

	[TypeScriptModule("Constants")]
	public enum enTaskStatusInfo {
		[DescriptionAttribute("User Deleted")]
		UserDeleted,
		Unassigned,
		LinkRemoved,
		WorkflowChange,
		[DescriptionAttribute("Document Deleted")]
		DocumentDeleted,
		Accepted,
		Refused,
		LeaveNotCompliant,
		Reassigned,
		Cancelled
	}

	[TypeScriptModule("Constants")]
	public enum enGenericActionTypes {
		ACCEPT,
		REVISE,
		DECLINE,
		CANCEL,
		READ,
		NONE,
		COMPLETE
	}

	[TypeScriptModule("Constants")]
	public enum enImportDateFormats {
		[DescriptionAttribute("MM/DD/YYYY")]
		MMDDYYYY_Slash = 0,
		[DescriptionAttribute("DD/MM/YYYY")]
		DDMMYYYY_Slash = 1,
		[DescriptionAttribute("DD.MM.YYYY")]
		DDMMYYYY_Period = 2,
		[DescriptionAttribute("DD-MM-YYYY")]
		DDMMYYYY_Dash = 3,
		[DescriptionAttribute("YYYY/MM/DD")]
		YYYYMMDD_Slash = 4,
		[DescriptionAttribute("YYYY.MM.DD")]
		YYYYMMDD_Period = 5,
		[DescriptionAttribute("YYYY-MM-DD")]
		YYYYMMDD_Dash = 6,
		[DescriptionAttribute("MM-DD-YYYY")]
		MMDDYYYY_Dash = 7,
		[DescriptionAttribute("FileTime")]
		FileTime = 8
	}

	[TypeScriptModule("Constants")]
	public enum enTimeFormats {
		[DescriptionAttribute("HH:MM am/pm")]
		HHMMampm_Colon = 0,
		[DescriptionAttribute("HH:MM")]
		HHMM_Colon = 1,
		[DescriptionAttribute("HH.MM am/pm")]
		HHMMampm_Period = 2,
		[DescriptionAttribute("HH.MM")]
		HHMM_Period = 3,
		[DescriptionAttribute("HH,MM")]
		HHMM_Comma = 4,
	}

	[TypeScriptModule("Constants")]
	public enum enLinkedDocTaskTypes {
		NEW_VERSION,
		REPLACED,
		ARCHIVED,
		NO_LINK_TASK_NEEDED
	}

	[TypeScriptModule("Constants")]
	public enum enDocGroupOrUserSetActions {
		OVERWRITE,
		ADD,
		REMOVE
	}

	[TypeScriptModule("Constants")]
	public enum enProxyModifyTaskAction {
		CREATE_NEW,
		COMPLETE_CURRENT
	}

	[TypeScriptModule("Constants")]
	public enum enQuizDisplayMode {
		NONE,
		EDIT,
		REVIEW,
		TAKE,
		RESULTS
	}

	[TypeScriptModule("Constants")]
	public enum enQuizFeedback {
		NONE = 0,
		ALL = 1,
		INCORRECT_QUESTIONS = 2
	}

	[TypeScriptModule("Constants")]
	public enum enQuizQuestionType {
		MULTIPLE_CHOICE = 0,
		TRUE_OR_FALSE = 1,
		OPEN_ENDED = 2,
		YES_OR_NO = 3
	}

	[TypeScriptModule("Constants")]
	public enum enPPMBool {
		TRUE = 1,
		FALSE = 0,
		IGNORE = -1
	}

	[TypeScriptModule("Constants")]
	public enum enWorkflowRuleIconCodes {
		[DescriptionAttribute("")]
		None = 0,
		[DescriptionAttribute("PT_orb-check.png")]
		CheckMark = 1,
		[DescriptionAttribute("PT_orb-x.png")]
		XMark = 2,
		[DescriptionAttribute("PT_misc-save.png")]
		SaveIcon = 3
	}

	[TypeScriptModule("Constants")]
	public enum enDefaultTab {
		SiteDefault = 0,
		Tasks = 1,
		Search = 2,
		Reports = 3,
		Browse = 4,
		Favorites = 5,
		Recent = 6,
		Inbox = 8,
		Home = 9,
		MyDashboard = 10,
	}

	[TypeScriptModule("Constants")]
	public enum enPPMAsposeOpenFileErrorMsg {
		NoErrors = 0,
		FileIsProtected = 1,
		FileCannotBeOpened = 2,
		FileCannotBeReadFrom = 3,
		FileIsZeroLength = 4,
		FileNotValidAsposeFileType = 5,
		FileNotValidAsposeFile = 6,
		FileIsCorrupt = 7,
		FileIsPasswordProtected = 8,
		FileIsPreWord97 = 9
	}

	[TypeScriptModule("Constants")]
	public enum enUserType {
		EMPLOYEE = 0,
		CONTACT = 1,
		SYSTEMUSER = 2
	}

	[TypeScriptModule("Constants")]
	public enum enUserActivationStatus {
		NOT_NOTIFIED,
		NOTIFIED,
		ACTIVATED
	}

	[TypeScriptModule("Constants")]
	public enum enDocumentVariableValueConversion {
		DONOTCONVERT = 1,
		CONVERTTOTICKS = 2,
		CONVERTTOLOCALDATETIME = 3,
		CONVERTTOTEMPLATETEXT = 4
	}

	[TypeScriptModule("Constants")]
	public enum enImageType {
		[DescriptionAttribute("SiteLogo")]
		SITELOGO = 1,
		[DescriptionAttribute("CorporateLogo")]
		CORPORATELOGO = 2,
		[DescriptionAttribute("LoginLogo")]
		LOGINLOGO = 3
	}

	[TypeScriptModule("Constants")]
	public enum enVideoViewerMode {
		Inline,
		Popup,
		NewWindow
	}

	[TypeScriptModule("Constants")]
	public enum enFindUserBrowseByMode {
		User = 0,
		Department = 1,
		JobTitle = 2,
		Role = 3,
		Date = 4,
		Integer = 5,
		String = 6
	}

	[TypeScriptModule("Constants")]
	public enum enDimensionSelectorType {
		LIST=0,
		DATE=1,
		INTEGER=2,
		STRING=3,
		TREE=4
	}

	[TypeScriptModule("Constants")]
	public enum enSyncLogReportOptions {
		ALL = 0,
		ERRORSANDCHANGES = 1,
		ONLYERRORS = 2,
		ONLYCHANGES = 3
	}

	[TypeScriptModule("Constants")]
	public enum enEmailFailureCodes {
		NONE = 0,
		[DescriptionAttribute("Domain not found")]
		DOMAINNOTFOUND = 1,
		[DescriptionAttribute("Email address not found")]
		EMAILNOTFOUND = 2,
		[DescriptionAttribute("Email delayed")]
		DELAY = 3,
		[DescriptionAttribute("Other")]
		OTHER = 4,
		[DescriptionAttribute("Email Send Failure")]
		EMAILSENDFAILURE = 5
	}

	[TypeScriptModule("Constants")]
	public enum enIconTypes {
		IMAGE,
		FONT
	}

	[TypeScriptModule("Constants")]
	public enum enGridDisplayMode {
		LIST = 0,
		GRID = 1
	}

	[TypeScriptModule("Constants")]
	public enum enScreenType {
		MOUSE = 0,
		TOUCH = 1,
	}

	[TypeScriptModule("Constants")]
	public enum enActionQueueTypes {
		LOGIN = 0,
		LOGOUT = 1,
		DBCHANGED = 2
	}

	[TypeScriptModule("Constants")]
	public enum enEmailSettingsSendMethod {
		[DescriptionAttribute("Navex")]
		USENAVEX = 1,
		[DescriptionAttribute("Custom")]
		USEOWNSERVER = 2
	}
	/// <summary>Metadata Import Error Type</summary>
	[TypeScriptModule("Constants")]
	public enum enBulkImportDataErrorTypes {
		None = 0,//No errors logged...successfull import.
		Medium = 1, //recommendation is to correct, but data is still valid (mismatches or duplicates)
		High = 2,   //The data in the field will be ignored (invalid data)
		Critical = 3//Document cannot succeed in the import
	}

	[TypeScriptModule("Constants")]
	public enum enMetaDataLinkedDocsImportStatus {
		COMPLETE,
		INCOMPLETE,
		NEVER_RUN
	}

	[TypeScriptModule("Constants")]
	public enum SortOrder {
		[DescriptionAttribute("ASC")]
		Ascending,
		[DescriptionAttribute("DESC")]
		Descending
	}

	[TypeScriptModule("Constants")]
	public enum enBulkImportCellValidationLevel {
		NONE = 0,
		STRINGCONVERSION = 1,
		ROWTOTARGET = 2,
		ROWTOIMPORT = 3
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enCategoryVersionStatus {
		PENDING = 1,
		ACTIVE = 2,
		ARCHIVED = 4
	}

	[Flags]
	[TypeScriptModule("Constants")]
	public enum enComplianceStatus {
		NOTCOMPLIANT = 1,
		COMPLIANT = 2,
		ENDED = 4,
		UNLINKED = 8
	}

	[TypeScriptModule("Constants")]
	public enum enEndDateReason {
		DOCUMENTARCHIVED = 1,
		DOCUMENTDELETED = 2,
		SUBCATEGORYDELETED = 3,
		UNASSIGNEDFROMDOCUMENT = 4,
		SETASNOTCOMPLIANT = 5
	}

	[TypeScriptModule("Constants")]
	public enum enSubCategoryChanges {
		NOCHANGES = 1,
		TITLE = 2,
		DESCRIPTION = 3,
		BOTH = 4
	}

	[TypeScriptModule("Constants")]
	public enum enCategoryVersionChanges {
		NOCHANGES = 1,
		TITLE = 2,
		DESCRIPTION = 3,
		BOTH = 4
	}

	[TypeScriptModule("Constants")]
	public enum enReportChartTypes {
		[DescriptionAttribute("pie")]
		Pie = 1,
		[DescriptionAttribute("bar")]
		Bar = 2
	}

	[TypeScriptModule("Constants")]
	public enum enReportColumns {
		DocReviewInterval = 1,
		DocReadInterval = 2,
		DocVersion = 3,
		DocTitleWithID = 4,
		DocDateApproved = 5,
		DocDateCreated = 6,
		DocEffectiveOrSpecifiedPublicationDate = 7,
		DocDateExpire = 8,
		DocWorkflowStatus = 9,
		DocOwnerFullNameLNFirstWithJobTitle = 10,
		DocOwnerDepartment = 11,
		DocOwnerSite = 12,
		DocReferenceNumber = 13,
		DocCompComplianceDate = 14,
		DocCompComplianceStatusDisplayText = 15,
		DocCompEndDate = 16,
		DocCompEndDateReasonDisplayText = 17,
		CatVerTitleWithPath = 18,
		CatVerVersion = 19,
		CatVerActivationDate = 20,
		AssignedReadersCount = 21,
		IncompleteReadersCount = 22,
		CompleteReadersCount = 23,
		OverdueReadersCount = 24,
		PercentReaderComplete = 25,
		AssignedCustomTasksCount = 26,
		IncompleteCustomTasksCount = 27,
		CompleteCustomTasksCount = 28,
		OverdueCustomTasksCount = 29,
		PercentCustomTasksComplete = 30,
		CatVerComplianceDisplayText = 31,
		DocumentID = 32,
		//TaskByDocumentReport Specific
		DateLastSubmitted = 33,
		DurationInCurrentWorkflow = 34,
		DocCurrentCycle = 35,
		DaysInCurrentCycle = 36,
		WriterTasksCount = 37,
		ReaderTasksCount = 38,
		ReviewerTasksCount = 39,
		ApproverTasksCount = 40,
		DocOwnerTasksCount = 41,
		RemainingTasksCount = 42,
		TotalCompletedTasks = 43,
		TaskStatus = 44,
		TaskType = 45,
		AssignedUser = 46,
		Action = 47,
		DateCompleted = 48,
		TaskDueDate = 49,
		DaysUntilDue = 50,
		UserSite = 51,
		UserDepartment = 52,
		TasksDueStatus = 53,
		TasksCycle = 54,
		TasksProcessLevel = 55,
		DocCurrentLevel = 56,
		DateAssigned = 57,
		AssignedUserUniqueEmployeeID = 58,
		DocOwnerUserID = 59,
		DocOwnerUniqueEmployeeID = 60,
		ThirdPartyDepartment = 61,
		ThirdPartyAccountName = 62,
		ThirdPartyJobTitle = 63,
		DocLocalizationType = 64,
		UserJobTitle = 65,
		AssigneeLanguage = 66,
		TaskIsCompliance = 67,
		TaskCompletedByProxy = 68,
		TaskCompletedWithEnhancedValidation = 69,
		TaskCompletedOnLocalizedCopy = 70,
		DocOriginalCreationDate = 71,
		DocLastExternalReviewDate = 72
	}

	[TypeScriptModule("Constants")]
	public enum enReportColumnTypes {
		STRING,
		INT,
		DATE,
		PERCENT
	}

	[TypeScriptModule("Constants")]
	public enum enReportFieldClasses {
		Document = 1,
		CategoryVersion = 2,
		DocumentCompliance = 3,
		UserAction = 4,
	}

	[TypeScriptModule("Constants")]
	public enum enReportColumnSummationTypes {
		Sum = 1,
		PercentTotal = 2,
		PercentTrue = 3
	}

	[TypeScriptModule("Constants")]
	public enum enReportColumnOverrideDisplayType {
		Percent = 1
	}

	[TypeScriptModule("Constants")]
	public enum enReportSummaryViews {
		CUSTOM = 0,
		DOCUMENT_COMPLIANCE = 1,
		READER_COMPLIANCE = 2,
		AUDITOR_VIEW = 3,
		CUSTOM_TASKS = 4,
		TASK_TYPE = 5,
		TASK_STATUS = 6
	}

	[TypeScriptModule("Constants")]
	public enum enBulkEditActionResult {
		SUCCESS = 1,
		FAILURE = 2,
		WARNING = 3
	}

	[TypeScriptModule("Constants")]
	public enum enImageTypes {
		GENERIC = 1,
		SITES = 2,
		USER_GROUPS = 3,
		CATEGORIES = 4,
		USERS = 5,
		TEMPLATES = 6,
		JOB_TITLES = 7
	}

	[TypeScriptModule("Constants")]
	public enum enTreeItemType {
		HEADING = 0,
		CUSTOM_ATTRIBUTE = 1,
		DEPARTMENT = 2,
		JOBTITLE = 3,
		USER = 3
	}

	[TypeScriptModule("Constants")]
	public enum enCustomAttributeTypes {
		STRING = 0,
		INTEGER = 1,
		DATE = 2
	}

	[TypeScriptModule("Constants")]
	public enum enDashboardVisability {
		OFF = 0,
		POWERUSERS = 1,
		ALL = 2
	}

	[TypeScriptModule("Constants")]
	public enum enGroupRuleType {
		USER = 0,
		ORGANIZATION = 1,
		CUSTOMATTRIBUTE = 2,
		ASSIGNMENT_TYPE = 3
	}

	[TypeScriptModule("Constants")]
	public enum enGroupRuleCompareType {
		ID_EQUALS = 0,
		STRING_EQUALS = 1,
		STRING_CONTAINS = 2,
		STRING_BEGINS_WITH = 3,
		STRING_ENDS_WITH = 4,
		INT_EQUALS = 5,
		INT_LESS_THAN = 6,
		INT_GREATER_THAN = 7,
		INT_RANGE = 8,
		DATE_EQUALS = 9,
		DATE_LESS_THAN = 10,
		DATE_GREATER_THAN = 11,
		DATE_RANGE = 12,
		DAYS_BEFORE_NOW = 13
	}

	[TypeScriptModule("Constants")]
	public enum enDashboardType {
		COMPANY = 0,
		MINE = 1
	}

	public enum enProcessProgressType {
		[DescriptionAttribute("ManualImportProgress")]
		ManualImport = 0,
		[DescriptionAttribute("ADSyncProgress")]
		ADSync = 1,
		[DescriptionAttribute("AutomatedUserSyncProgress")]
		AutomatedUserSync = 3
	}

	[Flags]
	public enum enCacheType {
		CONFIG_INI = 1,
		REGKEY = 2,
		APPLICATION_OPTIONS = 4,
		WORDWODULE_VERSION = 8,
		ONE_HOSTING_INI = 16,
		APP_CONFIG = 32,
		ALL_CLIENT = CONFIG_INI | REGKEY | APPLICATION_OPTIONS | WORDWODULE_VERSION
	}

	#endregion
}