<template>
  <div class="misa-input" :style="{ width: width }">
    <div class="input-label flex" v-if="inputLabel">
      {{ inputLabel }}
      <div class="require-mark" v-if="this.require" style="color: #ff0000">*</div>
    </div>
    <input
      :class="{'input--error': isError}"
      :type="inputType"
      v-model="inputValue"
      @input="updateValue($event.target.value)"
      :style="{ height: height , 'line-height': lineHeight}"
      :placeholder="placeHolder"
      :tabindex="tabindexInput"
      ref="dataInput"
    />
    <div class="error-message" v-if="errorMessage">{{ errorMessage }}</div>
  </div>
</template>

<script>
export default {
  name: 'MISATextfield',
  props: {
    errorMessage: String,
    inputLabel: String,
    lineHeight:String,
    placeHolder: String,
    height: String,
    width: String,
    iconAction: String,
    tabindexInput:String,
    isError:  {
      type: Boolean,
      default: false
    },
    inputType:{
      type: String,
      default: "text"
    },
    require: {
      type: Boolean,
      default: false
    },
    isFocus: {
      type: Boolean,
      default: false
    },
    modelValue:String
  },
  data() {
    return {
      inputValue: ''
    };
  },
  methods: {
    updateValue(value) {
      this.inputValue = value;
      this.$emit('update:modelValue', value);
    },
    setFocus(){
      this.$refs.dataInput.focus()
    }
  },
  created(){
   this.inputValue = this.modelValue
  },
  watch: {
    modelValue:function(){
      this.inputValue = this.modelValue
    }
  },
  mounted() {
    if (this.isFocus) this.$refs.dataInput.focus()
  }
}
</script>

<style scoped>
@import url('./MISATextfield.css');
</style>
