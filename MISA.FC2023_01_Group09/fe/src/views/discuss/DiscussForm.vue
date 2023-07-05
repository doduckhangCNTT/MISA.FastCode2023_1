<template>
  <div>
    <!-- header go here -->
    <div id="form-overlay" class="form-overlay">
      <div class="form" style="width: 600px">
        <div class="form__header">
          <div class="header__left">
            <div class="form__title">
              {{ formTitle }}
            </div>
          </div>
          <div class="header__right">
            <MISAIcon
              class="icon--close"
            ></MISAIcon>
          </div>
        </div>

        <!-- content go here -->
        <div
          class="form__content"
          style="display: flex"
        >
          <MISATextField
            v-model="x"
            :require="true"
            :isError="false"
            :isFocus="true"
            class="input__id"
            inputLabel="Họ và tên"
            height="28px"
            width="100%"
            tabindexInput="1"
            ref="EmployeeCode"
          ></MISATextField>
          <MISATextField
            v-model="x"
            :require="true"
            :isError="false"
            :isFocus="true"
            class="input__id"
            inputLabel="Tiêu đề"
            height="28px"
            width="100%"
            tabindexInput="1"
            ref="EmployeeCode"
          ></MISATextField>
          <div class="gender-area">
            <div class="input-label">Giới tính</div>
            <div class="gender-input">
              <div class="radio-nest">
                <input
                      type="radio"
                      id="customRadio"
                      name="customRadio"    
                      class="custom-radio"
                      group="gender"
                      option="male"
                  
                      v-model="e"
                    />
                    <lable class="radio-label">Nam</lable>
                  </div>
                  <div class="radio-nest">
                    <input
                      type="radio"
                      id="customRadio"
                      name="customRadio"
                      class="custom-radio"
                      group="gender"
                      option="female"
            
                      v-model="e"
                    />
                    <lable class="radio-label">Nữ</lable>
                  </div>
                  <div class="radio-nest">
                    <input
                      type="radio"
                      id="customRadio"
                      name="customRadio"
                      class="custom-radio"
                      group="gender"
                      option="other"
             
                      v-model="e"
                      />
                    <lable class="radio-label">Khác</lable>
                  </div>
                </div>
              </div>
            </div>
            <MISATextField
              v-model="x"
              :require="true"
              :isError="false"
              :isFocus="true"
              class="input__id"
              placeHolder="nội dung"
              height="100px"
              width="100%"
              tabindexInput="1"
              ref="EmployeeCode"
              lineHeight = "0px"
            ></MISATextField>
        <!-- footer go here -->
        <div class="form__footer flex">
          <div class="footer__left"></div>
          <div class="footer__right">
          <MISAButton>
            <template v-slot:button>
              <div @click="handleSaveClick" class="second-btn misa-btn-default-size">
                <div class="misa-btn-text">Hủy Bỏ</div>
              </div>
            </template>
          </MISAButton>
          <MISAButton>
            <template v-slot:button>
              <div @click="handleSaveAndAddClick" class="primary-btn misa-btn-default-size">
                <div class="misa-btn-text">Lưu</div>
              </div>
            </template>
          </MISAButton>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import MISAForm from "../../components/base/form/MISAForm.vue";
import MISAIcon from "../../components/base/icon/MISAIcon.vue";
export default {  
  name: "DiscussForm",
  props: {
    MISAForm,
    MISAIcon,
    formTitle: String,
  },
};
</script>

<style scoped>
@import url("../../css/views/form/DisscussForm.css");
</style>
