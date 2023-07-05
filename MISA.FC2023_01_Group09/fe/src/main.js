import { createApp } from 'vue'
import App from './App.vue'
import MSCombobox from 'ms-combobox'
import router from '@/router/router.js'
import emitter from 'tiny-emitter/instance'
import MISAResource from './helpers/resource'
import MISAEnum from './helpers/enum'
import axios from 'axios'


import DiscussList from "./views/discuss/DiscussList";
import DiscussPage from "./views/discuss/DiscussPage";
import DiscussListItem from "./views/discuss/DiscussListItem";
import DiscussResponseDetail from "./views/discuss/DiscussResponseDetail";


const app = createApp(App);
app.component("m-combobox", MSCombobox);


app.component("DiscussList", DiscussList);
app.component("DiscussPage", DiscussPage);
app.component("DiscussResponseDetail", DiscussResponseDetail);
app.component("DiscussListItem", DiscussListItem);

app.config.globalProperties.$_emitter = emitter;
app.config.globalProperties.$_MISAResource = MISAResource;
app.config.globalProperties.$_MISAEnum = MISAEnum;
app.config.globalProperties.$_LANG_CODE = "VN";
app.config.globalProperties.$_axios = axios;
app.use(router);
app.mount('#app')
export default app;