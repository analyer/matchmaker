<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/appmanager/publicresources/App_PublicResources.js此处编写
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
    import extend from "@/extension/appmanager/publicresources/App_PublicResources.js";
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
                    cnName: '公海资源',
                    name: 'publicresources/App_PublicResources',
                    url: "/App_PublicResources/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFields: {"CustomerName":"","Gender":"","Age":"","PhoneNo":"","BirthDate":""},
                editFormOptions: [[{"title":"客户姓名","required":true,"field":"CustomerName","type":"text"}],
                              [{"dataKey":"gender","data":[],"title":"性别","field":"Gender","disabled":true,"type":"radio"}],
                              [{"title":"年龄","field":"Age","type":"number"}],
                              [{"title":"电话","required":true,"field":"PhoneNo","type":"phone"}],
                              [{"title":"出生日期","field":"BirthDate","type":"month"}]],
                searchFormFields: {"PhoneNo":"","CustomerName":"","Gender":"","Age":""},
                searchFormOptions: [[{"title":"客户姓名","field":"CustomerName"},{"title":"电话","field":"PhoneNo"}],[{"dataKey":"gender","data":[],"title":"性别","field":"Gender","type":"select"},{"title":"年龄","field":"Age","type":"number"}]],
                columns: [{field:'Id',title:'Id',type:'string',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CreateDate',title:'创建日期',type:'datetime',sort:true,width:150,readonly:true,align:'left',sort:true},
                       {field:'CreateID',title:'CreateID',type:'int',width:100,hidden:true,readonly:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:100,readonly:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:100,readonly:true,align:'left'},
                       {field:'ModifyDate',title:'修改日期',type:'datetime',width:150,readonly:true,align:'left',sort:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:100,hidden:true,readonly:true,align:'left'},
                       {field:'PhoneNo',title:'电话',type:'string',width:110,require:true,align:'left'},
                       {field:'CustomerName',title:'客户姓名',type:'string',width:110,require:true,align:'left'},
                       {field:'Gender',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:110,readonly:true,align:'left'},
                       {field:'Age',title:'年龄',type:'int',width:110,align:'left'},
                       {field:'BirthDate',title:'出生日期',type:'datetime',width:150,align:'left',sort:true}],
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
