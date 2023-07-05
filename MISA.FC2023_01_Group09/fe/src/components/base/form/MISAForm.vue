<template>
  <div id="form-overlay" class="form-overlay">
    <div
      id="form"
      class="form"
      :style="{ 'max-width': maxWidth + 'px' }"
    >
      <!-- header go here -->
      <div class="form__header">
        <slot name="header"></slot>
      </div>

      <!-- content go here -->
      <div class="form__content">
        <slot name="content"></slot>
      </div>

      <!-- footer go here -->
      <div class="form__footer">
        <slot name="footer"></slot>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "MISAForm",
  props: {
    maxWidth: Number,
  },
};
</script>

<style scoped>
.form-overlay {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.5);
  overflow-y: auto;
  z-index: 9999;
}

.form {
  background-color: #fff;
  padding: 32px;
  height: 100%;
  text-align: center;
  box-sizing: border-box;
  border-radius: 4px;
  margin: 10px auto;
}

.form__header {
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.form__content {
  min-height: 100px;
  margin-top: 19px;
  margin-bottom: 36px;
  display: flex;
  flex-direction: column;
}

.form__footer {
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 12px;
  padding-top: 16px;
  border-bottom-left-radius: 4px;
  border-bottom-right-radius: 4px;
  border-top: 1px solid
    var(--default-border-color);
  box-sizing: border-box;
}
</style>
