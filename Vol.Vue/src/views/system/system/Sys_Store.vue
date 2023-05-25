<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/system/Sys_Store.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/system/system/Sys_Store.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Id',
                    footer: "Foots",
                    cnName: '门店信息表',
                    name: 'system/Sys_Store',
                    url: "/Sys_Store/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFields: {"Name":"","Address":""},
                editFormOptions: [[{"title":"门店名称","required":true,"field":"Name","type":"text"}],
                              [{"title":"门店地址","required":true,"field":"Address","type":"text"}]],
                searchFormFields: {"Name":"","Address":""},
                searchFormOptions: [[{"title":"门店名称","field":"Name","type":"text"}],[{"title":"门店地址","field":"Address","type":"text"}]],
                columns: [{field:'Id',title:'Id',type:'string',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',sort:true,width:150,align:'left',sort:true},
                       {field:'Creator',title:'创建人',type:'string',width:100,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:100,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:150,align:'left',sort:true},
                       {field:'Name',title:'门店名称',type:'string',width:110,require:true,align:'left'},
                       {field:'Address',title:'门店地址',type:'string',width:220,require:true,align:'left'}],
                detail: {
                    cnName: "#detailCnName",
                    table: "#detailTable",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
