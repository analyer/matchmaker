<template>
    <div class="user-info">
      <div>
        <vol-form ref="form" :load-key="true" :width="500" :formRules="editFormOptions" :formFileds="addFormFileds">
          <div slot="header">
            <Divider>
              <span class="ivu-icon ios-alert-outline">客户信息</span>
            </Divider>
          </div>
          <div slot="footer">
            <Button
              style="margin: 2px;float: right;"
              type="info"
              size="large"
              icon="md-checkmark-circle"
              short
              @click="modifyInfo"
            >保存</Button>
          </div>
        </vol-form>
      </div>
    </div>
  </template>
  <script>
  import VolForm from "@/components/basic/VolForm.vue";
  export default {
    components: {
      VolForm: VolForm,
      VolBox: () => import("@/components/basic/VolBox.vue"),
    },
    methods: {
      modifyInfo() {
        let url = "/api/App_Customer/Add";
        var postData = {
            delKeys:null,
            detailData:null,
            mainData:{
                Name:this.addFormFileds.name,
                NickName:this.addFormFileds.nickName,
                PhoneNo:this.addFormFileds.phoneNo,
                Age:this.addFormFileds.age,
                Gender:this.addFormFileds.gender,
                Address:this.addFormFileds.address,
                Level:this.addFormFileds.level,
                Store:this.addFormFileds.store,
                MatchmakerName:this.addFormFileds.matchmakerName,
            }
        }
        this.http.post(url, postData, true).then((x) => {
            if (!x.status) {
                return this.$message.error(x.message);
            }
            this.addFormFileds.name = "";
            this.addFormFileds.nickName=  "";
            this.addFormFileds.phoneNo=  "";
            this.addFormFileds.age=  18;
            this.addFormFileds.gender=  "";
            this.addFormFileds.address=  "";
            this.addFormFileds.level=  "";
            this.addFormFileds.store=  "";
            this.addFormFileds.matchmakerName=  "";
            this.$Message.success(x.message);
        });
      },
    },
    created() {
    //   this.http.post("/api/user/getCurrentUserInfo", {}, true).then((x) => {
    //     if (!x.status) {
    //       return this.$message(x.message);
    //     }
    //     x.data.createDate = (x.data.createDate || "").replace("T", " ");
    //     x.data.gender = x.data.gender + "";
    //     this.$refs.form.reset(x.data);
    //     this.userInfo.img = this.base.getImgSrc(
    //       x.data.headImageUrl,
    //       this.http.ipAddress
    //     );
    //     this.userInfo.createDate = x.data.createDate;
    //     this.userInfo.userName = x.data.userTrueName;
    //     this.userInfo.phoneNo = x.data.phoneNo;
    //     this.userInfo.email = x.data.email;
    //     //   this.editFormFileds = x.data;
    //   });
    },
    data() {
      return {
        addFormFileds: {
          name: "",
          nickName: "",
          phoneNo: "",
          age: 18,
          gender: "",
          address: "",
          level: "",
          store: "",
          matchmakerName: "",
        },
        editFormOptions: [
          [
            {
              columnType: "string",
              title: "姓名",
              field: "name",
              required: true,
              type: "text",
            },
          ],
          [
            {
              columnType: "string",
              title: "昵称",
              field: "nickName",
              required: true,
              type: "text",
            },
          ],
          [
            {
              columnType: "string",
              title: "联系方式",
              field: "phoneNo",
              required: true,
              type: "phone",
            },
          ],
          [
            {
              columnType: "int",
              title: "年龄",
              field: "age",
              required: true,
              type: "number",
              max:100,
              min:18,
            },
          ],
          [
            {
              dataKey: "gender",
              title: "性别",
              field: "gender",
              required: true,
              data: [],
              type: "radio",
            }
          ],
          [
            {
              columnType: "string",
              title: "详细住址",
              field: "address",
              type: "text",
            },
          ],
          [
            {
              dataKey: "customer_level",
              columnType: "string",
              title: "客户等级",
              field: "level",
              data: [],
              type: "select",
            },
          ],
          [
            {
              dataKey: "store",
              columnType: "string",
              title: "门店",
              field: "store",
              data: [],
              type: "select",
            },
          ],
          [
            {
              dataKey: "matchmaker",
              columnType: "string",
              title: "服务红娘",
              field: "matchmakerName",
              data: [],
              type: "select",
            },
          ],
        ],
      };
    },
  };
  </script>
  <style scoped>
  </style>
  
  <style lang="less" scoped>
  .user-info {
    box-shadow: rgb(214, 214, 214) 0px 4px 21px;
    position: absolute;
    transform: translateY(-40%);
    top: 40%;
    position: relative;
    margin: 0 auto;
    left: 0;
    width: 895px;
    right: 0;
    text-align: center;
    padding: 0px;
    //display: flex;
    > div {
      float: left;
      // height: 480px;
      padding-top: 10px;
    }
  }
  </style>
  
  
  