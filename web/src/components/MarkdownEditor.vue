<template>
    <MdEditor v-model="text" theme="dark" language="en-US" :codeStyleReverse="false" />
</template>

<script setup>
import { ref } from 'vue';
import { MdEditor } from 'md-editor-v3';
import 'md-editor-v3/lib/style.css';

const text = ref('# Hello Editor');
</script>