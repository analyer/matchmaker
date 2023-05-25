<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/appmanager/customer/App_Customer.js此处编写
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
    import extend from "@/extension/appmanager/customer/App_Customer.js";
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
                    cnName: '客户信息表',
                    name: 'customer/App_Customer',
                    url: "/App_Customer/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFields: {"NickName":"","Name":"","Gender":"","PhoneNo":"","Age":"","Level":"","Store":"","Address":"","MatchmakerName":"","Classification":""},
                editFormOptions: [[{"title":"姓名","field":"Name","type":"text"},
                               {"title":"昵称","field":"NickName","type":"text"}],
                              [{"dataKey":"isphone","data":[],"title":"联系方式","required":true,"field":"PhoneNo","type":"phone"},
                               {"dataKey":"gender","data":[],"title":"性别","field":"Gender","type":"radio"}],
                              [{"title":"年龄","field":"Age","type":"number"},
                               {"dataKey":"customer_level","data":[],"title":"客户等级","field":"Level","type":"select"}],
                              [{"title":"详细住址","field":"Address","type":"text"},
                               {"dataKey":"store","data":[],"title":"门店","field":"Store","type":"select"}],
                              [{"dataKey":"matchmaker","data":[],"title":"服务红娘","field":"MatchmakerName","type":"select"},
                               {"dataKey":"classification","data":[],"title":"客户分类","field":"Classification","type":"select"}]],
                searchFormFields: {"MatchmakerName":"","Store":"","Age":[null,null],"Level":"","Classification":"","Address":"","PhoneNo":"","NickName":"","Name":""},
                searchFormOptions: [[{"title":"姓名","field":"Name","type":"text"},{"title":"昵称","field":"NickName","type":"text"},{"dataKey":"isphone","data":[],"title":"联系方式","field":"PhoneNo","type":"text"}],[{"title":"详细住址","field":"Address","type":"text"},{"dataKey":"classification","data":[],"title":"客户分类","field":"Classification","type":"select"},{"dataKey":"customer_level","data":[],"title":"客户等级","field":"Level","type":"select"}],[{"title":"年龄","field":"Age","type":"range"},{"dataKey":"store","data":[],"title":"门店","field":"Store","type":"select"},{"dataKey":"matchmaker","data":[],"title":"服务红娘","field":"MatchmakerName","type":"select"}]],
                columns: [{field:'Id',title:'Id',type:'string',width:120,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:120,align:'left',sort:true},
                       {field:'Modifier',title:'修改人',type:'string',width:120,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:120,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',sort:true,width:120,align:'left',sort:true},
                       {field:'MatchmakerName',title:'服务红娘',type:'string',bind:{ key:'matchmaker',data:[]},width:120,align:'left'},
                       {field:'Store',title:'门店',type:'string',bind:{ key:'store',data:[]},width:120,align:'left'},
                       {field:'Gender',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:120,align:'left'},
                       {field:'Age',title:'年龄',type:'int',width:120,align:'left'},
                       {field:'Level',title:'客户等级',type:'string',bind:{ key:'customer_level',data:[]},width:120,align:'left'},
                       {field:'Classification',title:'客户分类',type:'string',bind:{ key:'classification',data:[]},width:120,align:'left'},
                       {field:'Address',title:'详细住址',type:'string',width:120,align:'left'},
                       {field:'PhoneNo',title:'联系方式',type:'string',bind:{ key:'isphone',data:[]},width:120,require:true,align:'left'},
                       {field:'NickName',title:'昵称',type:'string',width:120,align:'left'},
                       {field:'Name',title:'姓名',type:'string',link:true,width:120,align:'left'}],
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
